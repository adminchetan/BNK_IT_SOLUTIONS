using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{

    [Table("tbl_DomainDetails", Schema = "dbo")]
    public class tbl_DomainsDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string?  nameServer1 {get;set;}
        public string? nameServer2 { get; set; }
        public string? nameServer3 { get; set; }
        public string? nameServer4 { get; set; }
        public string? Outlet { get; set; }
        public string? Wholesale { get; set; }
        public string? CGST { get; set; }
        public string? SGST { get; set; }
        public string? MSRP { get; set; }
        public string? Description { get; set; }
    }
}
