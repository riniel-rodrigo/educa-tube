using educa_tube_code.Models;
using educa_tube_code.Services; // Adicionado para usar YouTubeApiService
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Chave da API do YouTube
string youtubeApiKey = "AIzaSyAcEF5KD31aHy3vzFr-_2NIr05KwvQrG1E";  // chave de API

// Adicione serviços ao contêiner
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => {
        options.LoginPath = "/Login/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    });

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Adicione o serviço YouTubeApiService ao contêiner de dependência
builder.Services.AddSingleton(new YouTubeApiService(youtubeApiKey));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
