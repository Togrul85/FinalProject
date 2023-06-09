using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) //miras aldigimiz classin constructorun cagirir
        {

        }

        public DbSet<Rtelecom>Rtelecoms { get; set; }
        public DbSet<Expensive> Expensives { get; set; }
        public DbSet<Blog> Blogs  { get; set; }


    }
}

