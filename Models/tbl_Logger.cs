using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uttaraonline.Models
{
    [Table("tbl_Logger", Schema = "dbo")]
    public class tbl_Logger
    {
        [Key]
        public int LogId { get; set; }
        public string Message { get; set; }

        public string Excepction { get; set; }
        public string  Level { get; set; }
        public DateTime Eventdate { get; set; }=DateTime.Now;
        public string TrackingCode { get; set; }

        public string EntityName { get; set; }




    }
}
