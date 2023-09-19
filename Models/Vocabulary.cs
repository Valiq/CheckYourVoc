using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckYourVoc.Models
{
    public class Vocabulary
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("WordEng")]
        public int WordEngId { get; set; }
        [ForeignKey("WordRus")]
        public int WordRusId { get; set; }
    }
}
