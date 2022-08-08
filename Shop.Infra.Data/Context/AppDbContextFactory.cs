using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Shop.Infra.Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            //TODO: Ajustar para pegar do appsettings
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-US1KUVV\\SQLEXPRESS;Initial Catalog=ShopDB;Integrated Security=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
