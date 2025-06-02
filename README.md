TodoListApp - ASP.NET
A simple and efficient Todo List application built with ASP.NET Core, designed to help users manage their daily tasks and stay organized.

Features
✅ Create, read, update, and delete todo items (CRUD operations)
📝 Mark tasks as complete or incomplete
🔍 Filter tasks by status (All, Active, Completed)
📱 Responsive design for desktop and mobile devices
💾 Data persistence with Entity Framework Core
🎨 Clean and intuitive user interface
Technologies Used
Backend: ASP.NET Core 6.0+
Database: SQL Server / SQLite (Entity Framework Core)
Frontend: HTML5, CSS3, JavaScript, Bootstrap
ORM: Entity Framework Core
Architecture: MVC (Model-View-Controller)
Prerequisites
Before running this application, make sure you have the following installed:

.NET 6.0 SDK or later
Visual Studio 2022 or Visual Studio Code
SQL Server (optional, can use SQLite for development)
Getting Started
1. Clone the Repository
git clone https://github.com/Khawla-alharthi/TodoListApp-Asp.Net.git
cd TodoListApp-Asp.Net
2. Restore Dependencies
dotnet restore
3. Update Database Connection String
Update the connection string in appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=todolist.db"
  }
}
4. Apply Database Migrations
dotnet ef database update
If migrations don't exist yet, create them:

dotnet ef migrations add InitialCreate
dotnet ef database update
5. Run the Application
dotnet run
The application will be available at https://localhost:5001 or http://localhost:5000.

Project Structure
TodoListApp/
├── Controllers/
│   ├── HomeController.cs
│   └── TodoController.cs
├── Models/
│   ├── TodoItem.cs
│   └── TodoContext.cs
├── Views/
│   ├── Home/
│   ├── Todo/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
├── Migrations/
├── appsettings.json
└── Program.cs
API Endpoints
Method	Endpoint	Description
GET	/	Home page
GET	/Todo	Get all todo items
GET	/Todo/Details/{id}	Get specific todo item
GET	/Todo/Create	Show create form
POST	/Todo/Create	Create new todo item
GET	/Todo/Edit/{id}	Show edit form
POST	/Todo/Edit/{id}	Update todo item
POST	/Todo/Delete/{id}	Delete todo item
POST	/Todo/ToggleComplete/{id}	Toggle completion status
Usage
Adding a Task: Click the "Add New Task" button and fill in the task details
Marking Complete: Click the checkbox next to a task or use the "Mark Complete" button
Editing a Task: Click the "Edit" button next to any task
Deleting a Task: Click the "Delete" button and confirm the action
Filtering Tasks: Use the filter buttons to show All, Active, or Completed tasks
Database Schema
TodoItem Table
Column	Type	Description
Id	int	Primary key (auto-increment)
Title	nvarchar(200)	Task title (required)
Description	nvarchar(500)	Task description (optional)
IsCompleted	bit	Completion status
CreatedDate	datetime2	Creation timestamp
DueDate	datetime2	Due date (optional)
Contributing
Fork the repository
Create a feature branch (git checkout -b feature/AmazingFeature)
Commit your changes (git commit -m 'Add some AmazingFeature')
Push to the branch (git push origin feature/AmazingFeature)
Open a Pull Request
Future Enhancements
 User authentication and authorization
 Categories and tags for tasks
 Task priorities
 Due date reminders
 Export tasks to various formats
 Dark mode theme
 Mobile app version
License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
Khawla Al-Harthi

GitHub: @Khawla-alharthi
Project Link: https://github.com/Khawla-alharthi/TodoListApp-Asp.Net
Acknowledgments
ASP.NET Core documentation
Entity Framework Core documentation
Bootstrap for responsive design
Font Awesome for icons
⭐ If you found this project helpful, please give it a star!
