using Microsoft.AspNetCore.Mvc.Rendering;
using TodoListWebApplication.Models;
using TodoListWebApplication.Models.Enums;

namespace TodoListWebApplication.ViewModels
{
    public class TodoViewModels
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime Deadline { get; set; }

        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

    }
}
