    using System.Data.Entity;
namespace Models
{

    public class ProductContext : DbContext
    {
        public ProductContext() : base("oliveoilwebsite")
        {
        }
        public DbSet<Category> Categories { get; set; } //the type declared within the angled brackets specifies the type of the genericclass DbSet
        public DbSet<Product> Products { get; set; }
    }

}