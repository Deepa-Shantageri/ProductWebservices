
using Microsoft.EntityFrameworkCore;
using Product_api.model;
namespace Product_api.Data
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> Users=>Set<User>();
          //public DbSet<Product> Products=>Set<Product>();
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Product>().HasData(
        //         new Product{Id=1,ProductName="Laptop",Price=100000},
        //          new Product{Id=2,ProductName="Mouse",Price=20000}
        //     );
        //     base.OnModelCreating(modelBuilder);
        // }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5433;Database=users;Username=postgres;Password=Deepamanju12#$");
            }
        }
    }
   
}