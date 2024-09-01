using Uttaraonline.DTO;

namespace Uttaraonline.Interfaces
{
    public interface IAuthHandler
    {

        public (bool,string) CheckMobileNumberExist(string mobilenumber);
        public (bool, string) checkEmailAlredyExist(string email);

        public (bool,string, string) CreateNewUser(AuthDTO authDTO);

        public (bool, string, string, string? token, int? userId, string? userEmail, string? UserDisplayName, List<int>?  roles ) ValidateUserForLogin(string username,string password);





        public bool UpdatedLastLoggedIn(string username);
        public bool UpdatedPassword(string username, string password);

        public IEnumerable<object> GetAllUsers();
    }
}
