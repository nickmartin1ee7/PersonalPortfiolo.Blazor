namespace PersonalPortfiolo.Blazor.Models;

public class Settings
{
    public bool NavBarEnabled { get; set; }
    public string? GitHubProfileUri { get; set; }
    public string? GitHubProfileApiUri { get; set; }
    public MainLayoutLink[]? MainLayoutLinks { get; set; }
    public AchievementItem[]? AchievementItems { get; set; }
}

public class MainLayoutLink
{
    public string? Title { get; set; }
    public string? Uri { get; set; }
    public string? ImageUri { get; set; }
}

public class AchievementItem
{
    public string? Title { get; set; }
    public string? SubTitle { get; set; }
    public string? Description { get; set; }
    public string? UriDescription { get; set; }
    public string? Uri { get; set; }
    public string[]? Bullets { get; set; }
}
