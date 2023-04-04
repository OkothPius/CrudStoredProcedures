using CrudStoredProcedures.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudStoredProcedures.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = string.Format(@"Data Source=DESKTOP-LOMK63U;Initial Catalog=SCHOOLDB;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }
    }
}
