using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{
    [Table("tbl_ClientDomainDetails", Schema = "dbo")]
    public class tbl_ClientDomainsDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DomainId { get; set; }
        public int ClientId { get; set; }
        public int HostingId { get; set; }
        public string ?ServerIP { get; set; }
        public string ?DomainName { get; set; }
        public string ?RegistrationDate { get; set; }
        public string ?Validity { get; set; }
        public string ?ExpiaryDate { get; set; }
        public string ?ServerAdmin { get; set; }
        public int DomainDetails { get; set; }

    }
}
