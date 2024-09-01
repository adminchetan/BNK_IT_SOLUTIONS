using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Uttaraonline.DBConfig;
using Uttaraonline.DTO;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
    public class AdminRepo : IAdmin
    {
        public readonly DBContextProduction _dBContextProduction;
        public AdminRepo(DBContextProduction dBContextProduction) 
        { 
        _dBContextProduction = dBContextProduction;
        
        }




        public bool UpdateRolesByUserId(tbl_RoleMaster roles)
        {
            var role = _dBContextProduction.tbl_Rolemaster.SingleOrDefault(r => r.UserId == roles.UserId);
            if (role != null)
            {
                role.AdminDashboard = roles.AdminDashboard;
                role.AdminRoleManager = roles.AdminRoleManager;
                role.AdminUserCreation = roles.AdminUserCreation;
                role.Clientdashboard = roles.Clientdashboard;
                role.ClientUserCreation = roles.ClientUserCreation;
                role.AdminApproval = roles.AdminApproval;
                role.ClientPayment = role.ClientPayment;
            }
            int result = _dBContextProduction.SaveChanges();
            return Convert.ToBoolean(result);
        }

        public tbl_RoleMaster GetRolesByUserId(int userId)
        {
            var result = _dBContextProduction.tbl_Rolemaster.FirstOrDefault(x => x.UserId == userId);
            return result;
        }


        public List<tbl_RoleMaster> GetAllRoles()
        {
            var result = _dBContextProduction.tbl_Rolemaster.ToList();
            return result;
        }


        public List<UserDTO> GetAllUsers()
        {
            var result = _dBContextProduction.tbl_UserMasters
                .Select(user => new UserDTO
                {
                    Id = user.Uid,
                    UserName= user.FirstName + " " + user.LastName,
                    Email=user.Email,
                    MobileNumber=user.MobileNumber,
                    serachString = user.FirstName + " " + user.LastName + "(" + user.Email + ")"
                }).ToList();

            return result;
        }

  

        public async Task<List<string>> GetColumnNamesAsync(string tableName)
        {
            var connection = _dBContextProduction.Database.GetDbConnection();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            var sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName";
            var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add(new SqlParameter("@tableName", tableName));

            var columnNames = new List<string>();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    columnNames.Add(reader.GetString(0));
                }
            }
            var columnsToExclude = new HashSet<string> { "Roleid", "UserId" };
            var filteredColumns = columnNames.Where(col => !columnsToExclude.Contains(col)).ToList();


            return (filteredColumns);
        }
    }
}
