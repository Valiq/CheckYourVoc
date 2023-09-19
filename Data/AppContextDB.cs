using CheckYourVoc.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckYourVoc.Data
{
    public class AppContextDB: DbContext
    {
        public AppContextDB(DbContextOptions<AppContextDB> options):base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }
        public DbSet<WordEng> EngWords { get; set; }
        public DbSet<WordRus> RusWords { get; set; }
    }
}
