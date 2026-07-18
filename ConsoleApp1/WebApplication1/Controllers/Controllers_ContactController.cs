using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        var contactData = new ContactViewModel
        {
            FullName = "Judiel Meguiel Mescallado",
            Email = "mjudielmeguiel@gmail.com",
            Phone = "09947388328",
            GitHubUrl = "https://github.com/mjudielmeguiel",
            LinkedInUrl = "https://www.linkedin.com/in/judiel-meguiel-mescallado-0ba736382/?skipRedirect=true",
            ResumeUrl = "~/files/resume.pdf"
        };

        return View(contactData);
    }

    [HttpPost]
    public IActionResult SendMessage(ContactFormViewModel form)
    {
        if (ModelState.IsValid)
        {
            // Here you would typically save to database or send email
            // For now, we'll just return success
            ViewBag.Message = "Thank you! Your message has been sent successfully.";
            return RedirectToAction("Index");
        }

        return View("Index");
    }
}
