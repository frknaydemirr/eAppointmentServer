using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace eAppointmentServer.Infrastructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Proje kök dizininden appsettings.json'u okuyacak
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Bağlantı adını senin config dosyana göre buraya yaz ("SqlServer" ya da "DefaultConnection")
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));


            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
