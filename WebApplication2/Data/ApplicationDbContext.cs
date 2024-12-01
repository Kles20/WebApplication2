
using Microsoft.EntityFrameworkCore;
using eDziennik.Models;

namespace eDziennik.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
//sadhasdgashfg12312341