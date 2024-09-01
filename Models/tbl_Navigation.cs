using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uttaraonline.Models
{

    [Table("tbl_Navigation",Schema ="dbo")]
    public class tbl_Navigation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int id { get; set; }
        public string? name { get; set; }
        public string? title { get; set; }
        public string? fa_class { get; set; }
        public string? link { get; set; }

 
    }
}
