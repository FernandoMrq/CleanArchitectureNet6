using Microsoft.EntityFrameworkCore;
using Shop.Infra.Data.Context;
using Shop.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var Services = builder.Services;
Services.AddControllers();
Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(
        builder.Configuration.GetConnectionString("ShopConnection"));
});

Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
Services.AddEndpointsApiExplorer();
Services.AddSwaggerGen();

ConfigureServices.AddServices(Services);
ConfigureServices.AddRepositories(Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
