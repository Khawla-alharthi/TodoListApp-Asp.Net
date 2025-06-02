using Microsoft.AspNetCore.Mvc;
using TodoListWebApplication.Context;
using TodoListWebApplication.Models;

namespace TodoListWebApplication.Controllers
{

    /*
    * add CRUD operations for Category entity >>
    * (Create Category), (ReadAll Category), (Read Category), (Update Category), (Delete Category)
    */

    public class CategoryController : Controller
    {
        // readonly field for the database context (set just once and then get)
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }


        // Read Category
        public IActionResult Index()
        {
            // Retrieve all categories from the database
            var categories = _context.Categories.ToList();
            return View(categories);
        }


        // Create Category - get
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Create Category - POST
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(obj);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);
        }


        // Update Category
        [HttpGet]
        public IActionResult Update(int? Id) {
            if (Id is null)
            {
                return BadRequest();
            }
            var category = _context.Categories.FirstOrDefault(category => category.Id == Id);
            if (category is null) 
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        public IActionResult Update(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(obj);
                _context.SaveChanges();
                // return to the Index action to show the updated list of categories
                // return RedirectToAction("Index");
                // or you can use the nameof operator to avoid hardcoding the action name
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }


       // Delete Category
       [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (ModelState.IsValid)
            {
                var obj = _context.Categories.FirstOrDefault(category => category.Id == Id);
                _context.Categories.Remove(obj);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
