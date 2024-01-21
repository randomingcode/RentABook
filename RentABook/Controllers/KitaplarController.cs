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
    }
}
