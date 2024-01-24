using Microsoft.AspNetCore.Mvc;

namespace RentABook.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
