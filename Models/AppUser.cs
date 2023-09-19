using System.ComponentModel.DataAnnotations;

namespace CheckYourVoc.Models
{
    public class AppUser
    {
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
