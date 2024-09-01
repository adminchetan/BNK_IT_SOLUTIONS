using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_ClientHostingDetails", Schema = "dbo")]
    public class tbl_ClientHostingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int HostingId { get; set; }
        public int ClientId { get; set; }
        public string ServerIP { get; set; }
        public string HostingName { get; set; }
        public string RegistrationDate { get; set; }
        public string Validity { get; set; }
        public string ExpiaryDate { get; set; }
        public string ServerAdmin { get; set; }
        public int HostingDetails {get;set;}
    }
}
