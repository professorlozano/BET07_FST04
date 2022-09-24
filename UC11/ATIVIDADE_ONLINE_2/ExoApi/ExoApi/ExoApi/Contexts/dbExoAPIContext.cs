using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext: DbContext
    {
        public dbExoAPIContext()
        {
        }
        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = VMLOZANO\\SQLEXPRESS; initial catalog = dbExoAPI; User Id = sa; Password = vip12345");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }

    }
}
