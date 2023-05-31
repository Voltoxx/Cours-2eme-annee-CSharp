using CoursEnC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursEnC.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=ApplicationTuto;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Tuto> tuto { get; set; }
    }
}
