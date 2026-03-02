using CetStudentBook.Data;
using CetStudentBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CetStudentBook.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext context;

        public BooksController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: /Books
        public IActionResult Index()
        {
            List<Book> books = context.Books.ToList();
            return View(books);
        }

        // GET: /Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Books/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: /Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Books/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: /Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = context.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
