using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
    public class RoleManagerRepo : IRoleManager
    {
        private readonly DBContextProduction _dBContextProduction;
        public RoleManagerRepo(DBContextProduction dBContextProduction)
        {
            _dBContextProduction = dBContextProduction;
        }

        public string GetLeftMenuItems()
        {
            throw new NotImplementedException();
        }
    }
}
