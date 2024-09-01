using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : Controller
    {
        public readonly IAdmin _admin;
        public AdminController(IAdmin admin)
        {
         _admin=admin;
        }

        [HttpGet]
        public IActionResult GetAllTypesOfRoles()
        {
           var result = _admin.GetAllRoles();
            return Json(new { data = result });
        }
        [HttpGet]
        public IActionResult GetAllUserList()
        {
            var result = _admin.GetAllUsers();
            return Json(new { data = result });
        }


        [HttpGet]
        public async Task<IActionResult> GettAllColumsofroles()
        {
            var columnsnams = await _admin.GetColumnNamesAsync("tbl_RoleMaster");

            return Json(new { data = columnsnams });

        }

        [HttpGet]
        public IActionResult GetRolesById(int userid)
        {
            var result = _admin.GetRolesByUserId(userid);
            return Json(new { data = result });
        }

        [HttpPost]
        public IActionResult UpdateRolesById([FromBody]tbl_RoleMaster roles)
        {
            var result = _admin.UpdateRolesByUserId(roles);
            return Json(new { data = result });
        }

    }
}
