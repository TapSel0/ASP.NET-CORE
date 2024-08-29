using Microsoft.AspNetCore.Mvc;
using asp_gpt.Models;

namespace asp_gpt.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            var product = new Car
            {
                Id = 1,
                Name = "Test",
                Price = 41.423M
            };

            return View(product);
        }
    }
}
