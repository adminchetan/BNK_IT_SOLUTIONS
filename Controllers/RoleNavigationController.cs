using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleNavigationController : Controller
    {

        public readonly DBContextProduction _dBContextProduction;

        public RoleNavigationController(DBContextProduction dBContextProduction) 
        {
            _dBContextProduction = dBContextProduction;       
        }

        [HttpGet]
        public IActionResult GeAllNavigationList()
        {
            //var navigations =  _dBContextProduction.tbl_Navigation.ToListAsync();
            //var result = _rolemanager.GetLeftMenuItems();
            return Json("");
        }
    }
}
