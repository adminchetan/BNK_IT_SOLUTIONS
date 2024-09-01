using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_ServicesMaster", Schema = "dbo")]
    public class tbl_ServicesMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ServiceId", TypeName = "int")]
        public int Id { get; set; }

        [Column("ServiceName", TypeName = "nvarchar(max)")]
        public string Name { get; set; } = string.Empty;

        [Column("ServiceDescription", TypeName = "nvarchar(max)")]
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public int ServiceType { get; set; }

    
    }


}
