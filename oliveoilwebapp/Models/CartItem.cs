using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CartItem
    {
        [Key] //The Key attribute of the ItemId property specifies that the ItemID property is the primary key
        public string ItemId { get; set; }

        public string CartId { get; set; } //specifies the ID of the user that is associated with the item to purchase.

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}