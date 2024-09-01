using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Uttaraonline.DBConfig;
using Uttaraonline.DTO;
using Uttaraonline.Interfaces;
using Uttaraonline.JWTModels;
using Uttaraonline.LoggerInterface;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
 
    public class AuthHandlerRepository : IAuthHandler
    {
        private readonly IEventLogger _logger;

        private readonly DBContextProduction _dbContextProduction;

        public readonly JwtOptions _jwtOptions;

        public AuthHandlerRepository(IEventLogger logger,DBContextProduction dBContextProduction, IOptions<JwtOptions> options)
        {

            _logger = logger;
            _dbContextProduction = dBContextProduction;
            _jwtOptions = options.Value ?? throw new ArgumentNullException(nameof(options.Value), "JwtOptions value cannot be null.");

        }
        public (bool, string) checkEmailAlredyExist(string email)
        {
            var i = false;

            if (email != null)
            {
                i = _dbContextProduction.tbl_UserMasters.Any(x => x.Email == email);
            }

            if (i == true)  //mobile number already Exists
            {
                return (i, "warning");
            }

            else //mobile number already not Exists
            { 
            return (i, "success");
            }

           
        }

        public (bool, string) CheckMobileNumberExist(string mobilenumber)
        {
            var i = false;
            if(mobilenumber != null)
            {
                i = _dbContextProduction.tbl_UserMasters.Any(x => x.MobileNumber == mobilenumber);
            }
            if (i == true)  //mobile number already Exists
            {
                return (i, "warning");
            }

            else //mobile number already not Exists
            {
                return (i, "success");
            }

        }

        public (bool, string,string) CreateNewUser(AuthDTO authDTO)
        {
            _logger.LogInformation("Attempting to create user account for " + authDTO.Email, authDTO.CurrentUser, "tbl_UserMaster");
            var (hash, salt) = GenerateHashAndSalt(authDTO.Password);

            tbl_UserMaster _tbl_UserMaster = new tbl_UserMaster()
            {
                Email = authDTO.Email,
                Hash = hash,
                Salt = salt,
                MobileNumber = authDTO.MobileNumber,
                FirstName = authDTO.FirstName,
                LastName = authDTO.LastName,
                CreatedOn = DateTime.Now,
                CreatedBy = authDTO.CurrentUser

            };

            try
            {
                _dbContextProduction.tbl_UserMasters.Add(_tbl_UserMaster);
                var i = _dbContextProduction.SaveChanges();
                if (i == 1)
                {
                    _logger.LogInformation("User " + authDTO.Email + " Created successfully ", authDTO.CurrentUser, "tbl_UserMaster");
                    return (true,"success", "Account has been Created successfully");
                }

                else
                {
                    _logger.LogInformation("User Not Created" + authDTO.Email, authDTO.CurrentUser, "tbl_UserMaster");
                    return (false, "warning", "Account cannot be created");
                }

            }
            catch (Exception ex)
            {
                _logger.LogExcepction("User Cannot Be created Error :"+ ex.Message, authDTO.CurrentUser, "tbl_UserMaster");
                return (false,"error", "Account cannot be created due to technical error");
            }

       }

        public IEnumerable<object> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdatedLastLoggedIn(string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdatedPassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public (bool, string, string, string?, int?, string?, string?, List<int>?) ValidateUserForLogin(string username, string password)
        {
            var userCredentials = _dbContextProduction.tbl_UserMasters
            .Where(x => x.Email == username || x.MobileNumber == username)
            .Select(x => new { x.Salt, x.Hash, x.Uid, x.Email, x.FirstName, x.LastName })
            .FirstOrDefault();

            if (userCredentials != null)
            {
                string salt = userCredentials.Salt;
                string hashedPassword = userCredentials.Hash;
                int userID = userCredentials.Uid;
                string Username = userCredentials.Email;
                string UserCompleteName = userCredentials.FirstName + " " + userCredentials.LastName;

                var i = VerifyPassword(password, hashedPassword, salt);
                if (i == true)
                {
                    var roles = _dbContextProduction.tbl_UserRoleMappings
                                .Where(x => x.UserId == Convert.ToString(userID))
                                .Select(x => x.Roleid)
                                .ToList();

                    var token = generateToken(Username);
                    return (true, "success", "LoggedIn Successfully", token, userID, Username, UserCompleteName, roles);
                }
                else
                {
                    return (false, "warning", "Incorrect Password", null, null, null, null, null);
                }
            }
            else
            {
                _logger.LogInformation("Error while retrieving user information", username, "tbl_UserMasters");
                return (false, "warning", "Error while retrieving user information", null, null, null, null, null);
            }
        }


        private string  generateToken(string username)
        
        {
            var jwtkey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(_jwtOptions.Key));
            var credentials = new SigningCredentials(jwtkey, SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>()
            {
                new Claim ("username",username)
            };
            var sToken = new JwtSecurityToken(_jwtOptions.Key, _jwtOptions.Issuer, claims, expires: DateTime.Now.AddHours(1), signingCredentials: credentials);
            var token = new JwtSecurityTokenHandler().WriteToken(sToken);
            return token;


        }

        //CryptoGraphy//
        public static (string Hash, string Salt) GenerateHashAndSalt(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);

            // Combine salt and password
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password + Convert.ToBase64String(salt));

            // Hash the combined bytes
            using (var sha256 = new SHA256Managed())
            {
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                string hashedPassword = Convert.ToBase64String(hashedBytes);
                string saltString = Convert.ToBase64String(salt);
                return (hashedPassword, saltString);
            }
        }


        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            // Combine entered password and stored salt
            byte[] combinedBytes = Encoding.UTF8.GetBytes(enteredPassword + storedSalt);

            // Hash the combined bytes
            using (var sha256 = new SHA256Managed())
            {
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                string hashedPassword = Convert.ToBase64String(hashedBytes);

                // Compare the hashed entered password with the stored hash
                return hashedPassword == storedHash;
            }

        }



    }
}
