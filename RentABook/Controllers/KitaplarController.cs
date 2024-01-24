using Microsoft.AspNetCore.Mvc;
using RentABook.Interfaces;
using RentABook.Models;

namespace RentABook.Controllers
{
    public class KitaplarController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public KitaplarController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IActionResult> Index()
        {
           IEnumerable<Book> books =await _bookRepository.GetAll();
            return View(books);
        }

        public  IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(bookViewModel bvm)
        {

            return View();
        }
    }
}
