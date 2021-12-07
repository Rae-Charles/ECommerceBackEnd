using Microsoft.AspNetCore.Mvc;

namespace eCommerceStarterCode.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
