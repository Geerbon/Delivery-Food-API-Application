using DelFood.Web.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace DelFood.Web.ProductAPI.DbContexts
{


    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Shrimp in tom-yam sauce",
                Price = 14.99,
                Description = "Some description about greate food!",
                ImageUrl = "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Shrimp.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Tuna Salad",
                Price = 11.99,
                Description = "Some description about tasty food!",
                ImageUrl = "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Tuna salad.jpg",
                CategoryName = "Salads"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Some description about tasty food!",
                ImageUrl = "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Sweet pie.jpg",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Striploin steake with Dor blue cheese butter",
                Price = 19.99,
                Description = "Some description about tasty food!",
                ImageUrl = "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Steak.jpg",
                CategoryName = "Entree"
            });
        }
    }
}