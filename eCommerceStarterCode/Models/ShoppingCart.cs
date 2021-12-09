using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; } 
        
        [ForeignKey("User")]
        // required UserId, ProductId, Quantity 
        // UserId = string
        // ProductId = int
        // Quantity = int
        public string UserId{ get; set; }
        public User User { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
