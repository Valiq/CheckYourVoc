using System.ComponentModel.DataAnnotations;

namespace CheckYourVoc.Models
{
    public class WordEng
    {
        [Key]
        public int id { get; set; }
        public string? Word { get; set; }
    }
}
