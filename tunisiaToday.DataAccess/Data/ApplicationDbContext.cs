using Microsoft.EntityFrameworkCore;
using tunisiaToday.Models;

namespace tunisiaToday.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Article> Articles { get; set; }

    }
}
