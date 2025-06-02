using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TodoListWebApplication.Context;
using TodoListWebApplication.Models;
using TodoListWebApplication.ViewModels;

namespace TodoListWebApplication.Controllers
{
    public class TodoController : Controller
    {
        public readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // retreive all todos from database
            var todos = _context.Todos.ToList();
            return View(todos);
        }


        // this contains all categories user want to select when add new todo
        [HttpGet]
        public IActionResult Create()
        {
            var categories = _context.Categories.ToList();
            TodoViewModels viewModel = new TodoViewModels()
            {
                Categories = categories.Select(c => new SelectListItem()
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Create(TodoViewModels obj)
        {
            if (ModelState.IsValid)
            {
                Todo todos = new Todo()
                {
                    Name = obj.Name,
                    Description = obj.Description,
                    IsCompleted = obj.IsCompleted,
                    Deadline = obj.Deadline,
                    CategoryId = obj.CategoryId
                };
                _context.Todos.Add(todos);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            var categories = _context.Categories.ToList();
            obj.Categories = categories.Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            return View(obj);
        }
    }
}
