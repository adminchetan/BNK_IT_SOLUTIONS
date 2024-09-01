using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Uttaraonline.Interfaces;

namespace Uttaraonline.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ClientController : Controller
       
    {
        public readonly IClient _user;
        public ClientController(IClient user)
        {
            _user = user;

        }
        [HttpPost]
        public ActionResult SignUp()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult SignIn()
        {

           var token= GenerateToken();
            return token;
        }

        [HttpGet]
        public IActionResult GetClientInformation()
        {

            var res = _user.GetClientsInformation();

            return Json(new { success = true, data = res });
        }



        [HttpPost("token")]
        public IActionResult GenerateToken()
        {
            // Define your token settings
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ifZon4o0ydpUO4EloTveQNJy9bGRb41neZdVsQP8Y="));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "user_id"), // Add user-specific claims
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "uttaraonline",
                audience: "yourAudience",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);

            return Ok(new { FirstName="Champak",LastName="Joshi", Email="admin@uttaraonline.in",token = stringToken });
        }



    }
}
