using Microsoft.EntityFrameworkCore;


namespace logger.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

       
    }
}
