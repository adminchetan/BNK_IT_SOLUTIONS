using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_HostingDetails", Schema = "dbo")]
    public class tbl_HostingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MonthlyBandwidth { get; set; }
        public string? Storage { get; set; }
        public int? EmailAccount { get; set; }
        public string? Type { get; set; }
        public string? Backup { get; set; }
        public string? AccessToCpannel { get; set; }
        public string? AccessToFTP {get; set; }        
        public string? Outlet { get; set;}
        public string? Wholesale { get; set; }
        public string? CGST { get; set; }
        public string? SGST { get; set; }
        public string? MSRP { get; set; }
        public string? Description { get; set;}

       




    }
}
