using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_RoleMaster", Schema = "dbo")]
    public class tbl_RoleMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Roleid { get; set; }
        public int UserId { get; set; }

        public bool? AdminDashboard { get; set; } = false;
        public bool? AdminRoleManager { get; set; } = false;
        public bool? AdminUserCreation { get; set; } = false;

        public bool? AdminApproval { get; set; } = false;


        public bool? Clientdashboard { get; set; } = false;
        public bool? ClientUserCreation { get; set; } = false;
        public bool ?ClientPayment { get; set; } = false;
    }
}
