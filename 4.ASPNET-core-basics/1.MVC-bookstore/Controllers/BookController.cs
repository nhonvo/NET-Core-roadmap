using _1.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1.MVC.Controllers
{
    public class BookController : Controller
    {
        public readonly static List<Book> books =
        [
            new Book { Id = Guid.NewGuid(), Name = "I Am Rich B*tch", Year = 2024},
            new Book { Id = Guid.NewGuid(), Name = "Marry Me Please", Year = 2023},
        ];

        public IActionResult Index()
        {
            return View(books);
        }

        // GET: /Book/Details/1
        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // GET: /Book/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Book/Create
        [HttpPost("Create")]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = Guid.NewGuid();
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Book/Edit/1
        [HttpGet("Edit/{id}")]
        public IActionResult Edit(Guid id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /Book/Edit/1
        [HttpPost("Edit/{id}")]
        public IActionResult Edit(Guid id, Book book)
        {
            var existingBook = books.Find(b => b.Id == id);
            if (existingBook == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existingBook.Name = book.Name;
                existingBook.Year = book.Year;
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Book/Delete/1
        [HttpGet("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /Book/Delete/1
        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var book = books.Find(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Search")]
        public IActionResult Search(string? query)
        {
            var filteredBooks = books.Where(b => b.Name.Contains(query ?? "")).ToList();

            return View("Index", filteredBooks);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}