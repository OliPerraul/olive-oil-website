    using System.Data.Entity;
namespace WebSite1
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WebSite1")
        {
        }
        public DbSet<Category> Categories { get; set; } //the type declared within the angled brackets specifies the type of the genericclass DbSet
        public DbSet<Product> Products { get; set; }
    }
}
