using Microsoft.EntityFrameworkCore;

namespace Lab15_C.Request
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
        : base(options)
        {

        }
        public DbSet<UserRequest> Users { get; set; }
    }
}