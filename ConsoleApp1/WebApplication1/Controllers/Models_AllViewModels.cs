namespace WebApplication1.Models;

public class HomeViewModel
{
    public string? FullName { get; set; }
    public string? Title { get; set; }
    public string? Bio { get; set; }
    public string? ProfileImageUrl { get; set; }
}

public class AboutViewModel
{
    public string? FullName { get; set; }
    public string? Introduction { get; set; }
    public string? Goal { get; set; }
    public string? Education { get; set; }
    public int ExpectedGraduation { get; set; }
    public string? CareerGoal { get; set; }
}

public class SkillsViewModel
{
    public List<SkillCategory>? SkillCategories { get; set; }
}

public class SkillCategory
{
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public List<string>? Skills { get; set; }
}

public class ProjectsViewModel
{
    public List<Project>? Projects { get; set; }
}

public class Project
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Technologies { get; set; }
    public string? ImageUrl { get; set; }
    public string? GitHubUrl { get; set; }
}

public class ContactViewModel
{
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? GitHubUrl { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? ResumeUrl { get; set; }
}

public class ContactFormViewModel
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Subject { get; set; }
    public string? Message { get; set; }
}
