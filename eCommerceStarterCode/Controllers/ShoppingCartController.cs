using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var shoppingCart = _context.ShoppingCarts.Include(u => u.Product).Where(u => u.UserId == id);
            return Ok(shoppingCart);
            

        }
        [HttpPost, Authorize]
        // address api/shoppingcart
        // add product to table
        // body needs what is in the shopping cart model
        // dont forget to attach the JWT token
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }


         [HttpDelete("{ProductId}/{UserId}"), Authorize]
        public IActionResult Remove(int productId, string UserId)
        {
            var product = _context.ShoppingCarts.Find("{ProductId}/{UserId}");
    
             _context.ShoppingCarts.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }






        // add http get method - find by user Id simlar to LINQ problems 

        // add http delete method - previousely we only needed "{id}" now we will want to have ("{ProductId}/{UserId}")]
    }
}
