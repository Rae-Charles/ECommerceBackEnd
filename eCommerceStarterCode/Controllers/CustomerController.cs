using Microsoft.AspNetCore.Mvc;

namespace eCommerceStarterCode.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
