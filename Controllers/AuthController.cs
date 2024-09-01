using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Uttaraonline.DTO;
using Uttaraonline.Interfaces;
using Uttaraonline.JWTModels;
using Uttaraonline.LoggerInterface;
using Uttaraonline.Models;

namespace Uttaraonline.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : Controller
    {
        public readonly IAuthHandler _authHandler;
        public readonly LoggerInterface.IEventLogger _logger;
     
        public AuthController(IAuthHandler authHandler, LoggerInterface.IEventLogger logger,IOptions<JwtOptions> jwtOptions)
        {
            _authHandler = authHandler;
            _logger = logger;
  
        }
        [HttpPost]
        public IActionResult SignUp([FromBody] AuthDTO authDTO)
        {
            var ifExistvalidateMobile = false;
            var ifExistValidateEmail = false;
            string alertsMobile="error";
            string alertsEmail="error";
            if (authDTO != null)
            {
                (ifExistvalidateMobile, alertsMobile) = _authHandler.CheckMobileNumberExist(authDTO.MobileNumber);
                (ifExistValidateEmail, alertsEmail) = _authHandler.checkEmailAlredyExist(authDTO.Email);
                if (ifExistvalidateMobile == true)
                {
                    _logger.LogInformation("MobileNumber " + authDTO.MobileNumber + " already existe in system", authDTO.CurrentUser, "tbl_UserMaster");
                    return Json(new { success = false, alerts = alertsMobile, message = "MobileNumber already exist" });

                }
             
                else if (ifExistValidateEmail == true)
                {
                    _logger.LogInformation("User Email " + authDTO.Email + " Already Existe in System", authDTO.CurrentUser, "tbl_UserMaster");
                    return Json(new { success = false, alerts = alertsEmail, message = "Email already exist" });


                }
                else if (ifExistvalidateMobile == true && ifExistValidateEmail == true)
                {
                    return Json(new { success = false, alerts = "error", message = "MobileNumber & email already exist new account cannot be created" });
                }

                else
                {
                    var (success, alert, message) = _authHandler.CreateNewUser(authDTO);
                    return Json(new { Success = success, alerts = alert, Message = message });
                }
            }

            else
            {
                return Json(new { Success = false, alerts = "error", Message = "Invalid Form Data Passed" });
            }

                    
        
        
        }

        [HttpPost]
        public IActionResult SingIn([FromBody] LoginDTO LoginauthDTO)
        {
            var EmailExist = false;
            var MobileExist = false;
            var alertsMobile = "error";
            var alertsEmail = "eror";

            (MobileExist, alertsMobile) = _authHandler.CheckMobileNumberExist(LoginauthDTO.username);
            (EmailExist, alertsEmail) = _authHandler.checkEmailAlredyExist(LoginauthDTO.password);


            if (EmailExist || MobileExist)
            {
               var (success,alerttype,message,token,userid,userEmail,userDisplayName,roles) = _authHandler.ValidateUserForLogin(LoginauthDTO.username, LoginauthDTO.password);
                
               return Json(new { Success = success, alerts = alerttype, Message = message,token= token,userId=userid,userEmail=userEmail,userDisplayName=userDisplayName,asignedRole=roles });
           
            
            
            }

            else
            {
                return Json(new { Success = false, alerts = "warning", Message = "Invalid Username" });
            }
        }
    
    
    }
}
