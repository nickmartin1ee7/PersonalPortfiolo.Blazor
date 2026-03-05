using System.Net.Http.Headers;
using PersonalPortfiolo.Blazor.Services;
using PersonalPortfiolo.Blazor.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ISettingsService, SettingsService>();
builder.Services.AddTransient<IndexViewModel>();
builder.Services.AddTransient<AboutViewModel>();
builder.Services.AddTransient<AchievementsViewModel>();
builder.Services.AddTransient<ProjectsViewModel>();
builder.Services.AddTransient<ContactViewModel>();
builder.Services.AddSingleton(_ =>
{
    var client = new HttpClient();

    client.DefaultRequestHeaders.Host = "api.github.com";
    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Custom", "1.0.0"));
    client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

    return client;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();