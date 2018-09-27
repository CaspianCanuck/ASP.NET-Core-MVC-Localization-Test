using Microsoft.AspNetCore.Mvc;
using CoreLocalizationTest.Models;

namespace CoreLocalizationTest.Controllers
{
    [CultureFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestModel { TestString1 = Resources.Resource.Test };
            return View(model);
        }
    }
}
