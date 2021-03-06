using DateMe.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DateMe.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        
        public DbSet<Value> values { get; set; }

        public DbSet<User> users { get; set; }
        
    }
}