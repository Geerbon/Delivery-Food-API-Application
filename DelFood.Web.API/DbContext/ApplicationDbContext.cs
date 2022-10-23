using DelFood.Web.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DelFood.Web.ProductAPI.DbContexts
{

    
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}