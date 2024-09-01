using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;

namespace Uttaraonline.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ServerController : Controller
    {

        private readonly IServer _iServer;

        public ServerController(IServer iServer)
        {
            _iServer = iServer;
        }

     
        [HttpGet]
        public IActionResult getCompleteHostingDetailsOfUser()
        {
            int user = 100;

            var response = _iServer.getCompleteHostingDetailsOfUser(user);
            return Json(new {success = true, data= response });

        }

        [HttpGet]
        public IActionResult getCompleteDomainDetailsOfUser()
        {
            int user = 100;

            var response = _iServer.getCompleteDomainDetailsOfUser(user);
            return Json(new { success = true, data = response });

        }

        [HttpGet]
        public IActionResult GetBasicServerDetailsOfUser()
        {
            int user = 100;

            var response = _iServer.getCompleteHostingDetailsOfUser(user);
            return Json(new { success = true, data = response });

        }


        [HttpGet]
        public IActionResult GetDomainDetails()
        {
            int user = 100;

            var response = _iServer.GetDomainDetails(user);
            return Json(new { success = true, data = response });

        }
    }
}
