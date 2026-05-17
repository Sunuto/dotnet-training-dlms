using LibrarySystem.Business.BookBusiness;
using LibrarySystem.Repository.BookRepository;
using LibrarySystem.Business.LocationBusiness;
using LibrarySystem.Repository.LocationRepository;
using LibrarySystem.Repository.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddScoped<IBookBusiness, BookBusiness>();
builder.Services.AddScoped<ILocationBusiness, LocationBusiness>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
 options.UseSqlite(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
