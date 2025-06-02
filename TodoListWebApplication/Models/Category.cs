namespace TodoListWebApplication.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Navigation property for related Todo items
        public IEnumerable<Todo> Todos { get; set; } = new List<Todo>();
    }
}
