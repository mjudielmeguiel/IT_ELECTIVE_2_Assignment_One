using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var aboutData = new AboutViewModel
        {
            FullName = "Judiel Meguiel Mescallado",
            Introduction = "I am currently a third-year Bachelor of Science in Information Technology student. " +
                          "I have always been interested in how software and websites work, which led me to focus on " +
                          "programming and web development. Throughout my studies, I have learned to solve problems " +
                          "logically and work well both independently and in teams.",
            
            Goal = "My goal is to become a professional web developer and contribute to projects that help " +
                   "people and businesses. I plan to improve my skills in ASP.NET Core, databases, and " +
                   "front-end design. Outside of coding, I enjoy reading tech articles, playing games, and " +
                   "exploring new tools.",
            
            Education = "Bachelor of Science in Information Technology",
            ExpectedGraduation = 2027,
            CareerGoal = "To secure an internship and build production-ready applications."
        };

        return View(aboutData);
    }
}
