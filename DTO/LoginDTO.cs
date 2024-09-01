using System.ComponentModel.DataAnnotations;

namespace Uttaraonline.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username is required.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
