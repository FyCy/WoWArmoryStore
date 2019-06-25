using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoWArmory.Data.Models;

namespace WoWArmory.Data
{

    public class WoWArmoryDbContext : IdentityDbContext<User>
    {
        
        public WoWArmoryDbContext(DbContextOptions<WoWArmoryDbContext> options)
          : base(options)
        {
        }
        public WoWArmoryDbContext()
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C17BCEM\\SQLEXPRESS;Database=WoWArmoryStore;Integrated Security=True;");
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //    .AddJsonFile(@"C:\Visual Studio PRojects\New folder(2)\WoWArmoryStore\WoWArmoryStore\WoWArmoryStore\appsettings.json")
        //    .Build();
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        base.OnModelCreating(builder);

        
          // builder.Entity<Project>().HasKey(m => m.ProjectPath);
          // builder.Entity<Target>().HasKey(m => m.Guid);
          // base.OnModelCreating(builder);
        }
    }
}
