using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_ClientMaster", Schema = "dbo")]
    public class tbl_ClientMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ClientId", TypeName = "int")]
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string Description { get; set; }

        public string ClientBuiisnessEmail { get; set; }

        public string PrimaryContactName { get; set; } = string.Empty;

        public string PrimaryContactEmail { get; set; } = string.Empty;

        public string PrimarContactCountry { get; set; } = string.Empty;

        public string PrimarContactState { get; set; } = string.Empty;

        public string PrimarContactCity { get; set; } = string.Empty;

        public string PrimarContactAddress { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;
        public DateTime? CreatedOn { get; set; }

        public DateTime? LastLogin{ get; set;} 

        public int AccountStatus { get; set; } 
    
    }
}
