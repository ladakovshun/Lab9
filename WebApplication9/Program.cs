using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication9.Services;

var builder = WebApplication.CreateBuilder(args);

// Додаємо сервіс MVC
builder.Services.AddControllersWithViews();

// Реєстрація сервісу для отримання погоди
builder.Services.AddHttpClient<IWeatherService, WeatherService>(); // Додаємо HttpClient

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
