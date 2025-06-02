using System.ComponentModel.DataAnnotations.Schema;
using TodoListWebApplication.Models.Enums;

namespace TodoListWebApplication.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime Deadline { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; }
        public PriorityStatus Priority { get; set; } = PriorityStatus.Medium;

        // Navigation property for related Category
        // Foreign key for Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
    }
}
