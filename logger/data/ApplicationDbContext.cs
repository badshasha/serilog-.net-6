using Microsoft.EntityFrameworkCore;
using logger.Model;


namespace logger.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        DbSet<Logger> logs { get; set; }
       
    }
}
