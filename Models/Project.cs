namespace Portfolio.Models;

public class Project
{
    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public string[] Technologies { get; set; } = [];

    public string GithubUrl { get; set; } = "";

    public string? DemoUrl { get; set; }
}