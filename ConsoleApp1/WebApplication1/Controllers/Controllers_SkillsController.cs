using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class SkillsController : Controller
{
    public IActionResult Index()
    {
        var skillsData = new SkillsViewModel
        {
            SkillCategories = new List<SkillCategory>
            {
                new SkillCategory
                {
                    Icon = "bi-code-slash",
                    Title = "Languages",
                    Skills = new List<string> { "C#", "Visual Basic", "Java", "Python", "JavaScript" }
                },
                new SkillCategory
                {
                    Icon = "bi-globe",
                    Title = "Web Tech",
                    Skills = new List<string> { "HTML5", "CSS3", "Bootstrap 5", "ASP.NET MVC" }
                },
                new SkillCategory
                {
                    Icon = "bi-database",
                    Title = "Databases",
                    Skills = new List<string> { "SQL Server", "MySQL", "MS Access", "SQLite" }
                },
                new SkillCategory
                {
                    Icon = "bi-pc-display",
                    Title = "Tools",
                    Skills = new List<string> { "Visual Studio", "VB.NET", "Git", "GitHub" }
                }
            }
        };

        return View(skillsData);
    }
}
