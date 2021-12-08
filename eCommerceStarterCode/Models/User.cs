using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserEmail { get; set; }   
        public string Password { get; set; }        
       

    }
}
