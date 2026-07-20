using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_Midterm_A1_LastName_FirstName.Controllers
{
    public class HomeController : Controller
    {
        // Home Page
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["FullName"] = "Judiel Meguiel Mescallado";
            ViewData["Tagline"] = "Aspiring Software Developer & IT Student";
            ViewData["WelcomeMessage"] = "Welcome to my personal portfolio website. Here you can learn more about me, my skills, and the projects I have built.";
            return View();
        }

        // About Me Page
        public IActionResult About()
        {
            ViewData["Title"] = "About Me";
            ViewData["Bio"] = "I am a dedicated Information Technology student passionate about web development and software design. I love learning new technologies and building useful, user-friendly applications.";
            ViewData["Course"] = "Bachelor of Science in Information Technology";
            ViewData["School"] = "Your School / University Name";
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
                new {
                    Title = "Student Record System",
                    Description = "A CRUD application to manage student information and grades.",
                    Technologies = "C#, ASP.NET Core, Bootstrap 5, SQL Server",
                    Image = "/images/project1.jpg"
                },
                new {
                    Title = "Personal Portfolio Website",
                    Description = "Responsive portfolio site built using MVC architecture.",
                    Technologies = "HTML, CSS, Bootstrap 5, C#, Razor Views",
                    Image = "/images/project2.jpg"
                }
            };
            return View();
        }

        // Contact Page
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["Email"] = "mjudielmeguiel@gmail.com";
            ViewData["Phone"] = "+63 934 375 2396";
            ViewData["Location"] = "Metro Manila, Philippines";
            ViewData["GitHub"] = "https://github.com/mjudielmeguiel";
            return View();
        }
    }
}