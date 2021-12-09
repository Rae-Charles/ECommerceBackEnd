using eCommerceStarterCode.Data;
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
    public class ReviewController : Controller 
    {
        private readonly ApplicationDbContext _context;
        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _context.Reviews;     
            return Ok(reviews);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.ReviewId == id);
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

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]) Review value)



       // add http post with Authorize
       // user id logic like shopping cart
       //_context.Revies.Add(value);
       // context save changes like other example
       // reutnr ok with the (value)
    }
}
