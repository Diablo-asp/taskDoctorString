using Doctor_String.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor_String.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;DataBase=Doctor String;Integrated Security=True;" +
                "Trust Server Certificate=True");
        }
    }
}
