using Phoenix.Data.Interface;
using Phoenix.Data.Storage;
using Microsoft.EntityFrameworkCore;
using Phoenix.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWeatherCast, WeatherCast>();
builder.Services.AddScoped<IAllUrlForGames, AllUrlForGames>();
builder.Services.AddScoped<IAllComment, Comment>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDB>(options => options.UseSqlServer(connection));
 
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
