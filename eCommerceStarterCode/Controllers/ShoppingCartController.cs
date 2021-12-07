using Microsoft.AspNetCore.Mvc;

namespace eCommerceStarterCode.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
