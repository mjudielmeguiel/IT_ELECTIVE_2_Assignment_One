using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ProjectsController : Controller
{
    public IActionResult Index()
    {
        var projectsData = new ProjectsViewModel
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Title = "CodeNect System Alliance - POS & Inventory System",
                    Description = "Complete desktop Point of Sale and Inventory Management System with user accounts, sales tracking, product management, and vendor records.",
                    Technologies = "Visual Basic .NET, SQL Server",
                    ImageUrl = "https://via.placeholder.com/400x200.png?text=CodeNect+POS+System",
                    GitHubUrl = "https://github.com/mjudielmeguiel/CodeNect-System-Alliance.git"
                },
                new Project
                {
                    Title = "IT Elective 2 Prelim Exam - HttpClient",
                    Description = "Complete ASP.NET Core project using HttpClient for API communication and data fetching.",
                    Technologies = "C#, ASP.NET MVC, HttpClient",
                    ImageUrl = "https://via.placeholder.com/400x200.png?text=HttpClient+Project",
                    GitHubUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_PRELIM_EXAM.git"
                },
                new Project
                {
                    Title = "First MVC Application",
                    Description = "My first complete ASP.NET Core MVC web project with full project structure and layout setup.",
                    Technologies = "ASP.NET Core MVC, C#, HTML5, CSS3, Bootstrap",
                    ImageUrl = "https://via.placeholder.com/400x200.png?text=First+MVC+Application",
                    GitHubUrl = "https://github.com/mjudielmeguiel/First_MVC_Application.git"
                }
            }
        };

        return View(projectsData);
    }
}
