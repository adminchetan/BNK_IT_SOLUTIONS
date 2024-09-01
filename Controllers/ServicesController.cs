using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;

namespace Uttaraonline.Controllers
{
   
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly IServices _iservices;

        public ServicesController(IServices services)
        {
            _iservices = services;

        }
        [HttpGet]
        public IActionResult GetAllServices()
        {
       
            var res = _iservices.GetallServices();
            return Json(new { success = true, data = res });

        }
    }
}
