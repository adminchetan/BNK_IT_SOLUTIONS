using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uttaraonline.Models
{

    [Table("tbl_UserRoleMapping", Schema = "dbo")]
    public class tbl_UserRoleMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int Roleid { get; set; }
        public string UserId { get; set; }
    }
}
