using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_UserMaster", Schema = "dbo")]
    public class tbl_UserMaster
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Uid { get; set; }
        public string FirstName { get; set; }
        public string ?LastName { get; set; }
        public string Email {  get; set; }
        public string MobileNumber { get; set; }
        public string ?Roles { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public bool Active { get; set; }=false;
        public int AuditTail { get; set; } = 0;
        public DateTime CreatedOn { get; set; }=DateTime.Now;
        public DateTime LastLogin { get; set;}
        public string CreatedBy { get; set; }


    }
}
