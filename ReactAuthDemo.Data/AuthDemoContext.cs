using Microsoft.EntityFrameworkCore;

namespace ReactAuthDemo.Data
{
    public class AuthDemoContext : DbContext
    {
        private readonly string _connectionString;

        public AuthDemoContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<User> Users { get; set; }
    }
}