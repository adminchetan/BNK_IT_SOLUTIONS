using Microsoft.EntityFrameworkCore;
using Uttaraonline.Models;

namespace Uttaraonline.DBConfig
{
    public class DBContextProduction:DbContext
    {
        public DBContextProduction(DbContextOptions<DBContextProduction> options):base (options)
        {}

        public DbSet<tbl_ServicesMaster> tbl_ServiceMasters { get; set; }  // this is database table
        public DbSet<tbl_ServiceTypeMaster> tbl_ServiceTypeMaster { get; set; }  // this is database table
        public DbSet<tbl_ClientMaster> tbl_ClientMasters { get; set; }  
        public DbSet<tbl_ClientHostingDetails> tbl_ClientHostingDetails { get; set; }
        public DbSet<tbl_ClientDomainsDetails> tbl_ClientDomainsDetails { get; set; }
        public DbSet<tbl_HostingDetails> tbl_HostingDetails { get; set; }
        public DbSet <tbl_DomainsDetails> tbl_DomainsDetails { get; set; }
        public DbSet<tbl_UserMaster> tbl_UserMasters { get; set; }
        public DbSet<tbl_Logger> tbl_logger { get; set; }
       public DbSet<tbl_Navigation> tbl_Navigation { get; set; }

      public DbSet<tbl_NavSubMenu> tbl_NavSubMenus { get; set; }


        public DbSet<tbl_RoleMaster> tbl_Rolemaster { get; set; }
         
        public DbSet<tbl_UserRoleMapping> tbl_UserRoleMappings { get; set; }

       
    }

}
