using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var homeData = new HomeViewModel
        {
            FullName = "Judiel Meguiel Mescallado",
            Title = "Aspiring Software Developer",
            Bio = "IT student passionate about building clean, functional, and user-friendly web applications. I love learning new technologies and turning ideas into working systems.",
            ProfileImageUrl = "~/images/profile.jpg" // Update this with your actual image path
        };

        return View(homeData);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
