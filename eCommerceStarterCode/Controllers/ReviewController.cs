using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/examples")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/reviews
        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _context.Reviews;     
            return Ok(reviews);
        }

        // GET api/reviews/[productID]
        //Gets all Reviews for a Certain ProductID
        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
            var review = _context.Reviews.Where(r => r.ProductId == productId);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Review value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }


        //[HttpGet("rating/{productId}")]
        //public IActionResult GetRatings(int productId) { }



       // add http post with Authorize
       // user id logic like shopping cart
       //_context.Revies.Add(value);
       // context save changes like other example
       // reutnr ok with the (value)
    }
}
