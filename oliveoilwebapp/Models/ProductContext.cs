    using System.Data.Entity;
namespace Models
{

    public class ProductContext : DbContext //manages the entity classes and provides data access to the database.
    {
        public ProductContext() : base("oliveoilwebsite")
        {
        }
        public DbSet<Category> Categories { get; set; } //the type declared within the angled brackets specifies the type of the genericclass DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

        }

}