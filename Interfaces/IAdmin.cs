using Uttaraonline.DTO;
using Uttaraonline.Models;

namespace Uttaraonline.Interfaces
{
    public interface IAdmin
    {

        public List<UserDTO> GetAllUsers();

        public Task<List<string>> GetColumnNamesAsync(string tableName);

        public List<tbl_RoleMaster> GetAllRoles();
        public tbl_RoleMaster GetRolesByUserId(int userId);
        public bool UpdateRolesByUserId(tbl_RoleMaster roles);
     
       

    }
}
