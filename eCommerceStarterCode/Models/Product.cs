using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace eCommerceStarterCode.Models
{
    public class Product
    {
        [Key]
        
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Category { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }    
        public ICollection<Review> Reviews { get; set; }
        



    
    }
}
