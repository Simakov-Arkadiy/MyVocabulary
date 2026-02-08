using Microsoft.EntityFrameworkCore;
using MyVocabulary.DataAccess.Antites;
namespace MyVocabulary.DataAccess
{
    public class MyVocabularyDbContext : DbContext
    {
        public MyVocabularyDbContext(DbContextOptions<MyVocabularyDbContext> options) : base(options) 
        {
        }
        public DbSet<RecordEntity> Records { get; set; }
    }
}
