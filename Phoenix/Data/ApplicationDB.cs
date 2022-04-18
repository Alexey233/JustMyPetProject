using Microsoft.EntityFrameworkCore;
using Phoenix.Data.Models;

namespace Phoenix.Data
{
    public class ApplicationDB : DbContext
    {
        public DbSet<UsefulUrl> UsefulUrl { get; set; }
        
        public DbSet<Comments> Comments { get; set; }
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {
        }
       

    }
}
