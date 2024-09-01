using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_ServiceTypeMaster", Schema = "dbo")]
    public class tbl_ServiceTypeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ServiceTypeId", TypeName = "int")]
        public int Id { get; set; }

        [Column("ServiceTypeName", TypeName = "nvarchar(max)")]
        public string Name { get; set; } = string.Empty;

        [Column("ServiceTypeDescription", TypeName = "nvarchar(max)")]
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }


    }
}
