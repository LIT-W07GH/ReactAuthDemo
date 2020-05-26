using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ReactAuthDemo.Data
{
    public class AuthDemoContextFactory : IDesignTimeDbContextFactory<AuthDemoContext>
    {
        public AuthDemoContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}ReactAuthDemo.Web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

            return new AuthDemoContext(config.GetConnectionString("ConStr"));
        }
    }
}