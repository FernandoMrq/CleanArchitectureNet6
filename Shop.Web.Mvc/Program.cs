using Microsoft.EntityFrameworkCore;
using Shop.Infra.Data.Context;
using Shop.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);
var Services = builder.Services;

Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(
        builder.Configuration.GetConnectionString("ShopConnection"));
});

Services.AddControllersWithViews();

// Add services to the container.
Services.AddControllersWithViews();

ConfigureServices.AddServices(Services);
ConfigureServices.AddRepositories(Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
