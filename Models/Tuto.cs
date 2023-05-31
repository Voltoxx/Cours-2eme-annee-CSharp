using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursEnC.Models
{
    [Table("Tuto")]
    public class Tuto
    {
        [Key]
        public int Id { get; set; }

        public string titre { get; set; }

        public string description { get; set; }

        public string lienVideo { get; set; }

        public string? contenue { get; set; }
    }
}
