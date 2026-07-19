using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // Home Page
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["FullName"] = "[Judiel Meguiel Mescallado]";
            ViewData["Tagline"] = "Aspiring Software Developer & IT Student";
            ViewData["ShortIntro"] = "Passionate about building functional and responsive web applications using modern technologies.";
            return View();
        }

        // About Page
        public IActionResult About()
        {
            ViewData["Title"] = "About Me";
            ViewData["Bio"] = @"I am a dedicated Information Technology student with a strong interest in web development and software design. 
            I enjoy learning new programming languages and frameworks to create solutions that are useful and easy to use. 
            My goal is to grow as a developer and contribute to real-world projects.";
            ViewData["Course"] = "Bachelor of Science in Information Technology";
            ViewData["School"] = "[Pangalan ng Iyong Paaralan]";
            ViewData["YearLevel"] = "2nd Year";
            return View();
        }

        // Skills Page
        public IActionResult Skills()
        {
            ViewData["Title"] = "Skills";
            ViewData["SkillList"] = new[]
            {
                "HTML5 & CSS3",
                "Bootstrap 5",
                "C# Programming",
                "ASP.NET Core MVC",
                "SQL / Database Management",
                "Git & GitHub",
                "Basic JavaScript"
            };
            return View();
        }

        // Projects Page
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";
            ViewData["ProjectList"] = new[]
            {
                new
                {
                    Title = "Student Record System",
                    Description = "Web application to manage student information, grades, and records.",
                    Technologies = "C#, ASP.NET Core, Bootstrap 5, SQL Server",
                    Image = "/images/project1.jpg",
                    GitHub = "https://github.com/your-username/student-system"
                },
                new
                {
                    Title = "Personal Portfolio Website",
                    Description = "Responsive portfolio website built using MVC architecture.",
                    Technologies = "HTML, CSS, Bootstrap 5, C#, Razor",
                    Image = "/images/project2.jpg",
                    GitHub = "https://github.com/your-username/portfolio"
                },
                new
                {
                    Title = "Task Manager App",
                    Description = "Simple app to organize daily tasks and track progress.",
                    Technologies = "C#, ASP.NET Core, SQLite",
                    Image = "/images/project3.jpg",
                    GitHub = "https://github.com/your-username/portfolio"
                }
            };
            return View();
        }

        // Contact Page
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["Email"] = "mjudielmeguiel.com";
            ViewData["Phone"] = "+63 993 434 1387";
            ViewData["Location"] = "Muntinlupa City Metro Manila, Philippines";
            ViewData["GitHub"] = "https://github.com/your-username";
            return View();
        }
    }
}