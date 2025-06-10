using Doctor_String.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor_String.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorForm> DoctorForms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;DataBase=Doctor String;Integrated Security=True;" +
                "Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>()
                .HasData(new List<Doctor>
                {
                    new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg"      ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg"   ,StartWork= new TimeOnly(10,00)  ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg"    ,StartWork= new TimeOnly(10,00)  ,EndWork=new TimeOnly(18,00)},
                     new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg"   ,StartWork= new TimeOnly(10,00)  ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg"    ,StartWork= new TimeOnly(10,00)  ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 6, Name = "Dr. Hasnna ahmed", Specialization = "Neurology", Img = "doctor6.jpg"     ,StartWork= new TimeOnly(19,00)  ,EndWork=new TimeOnly(01,00)},
                });
            modelBuilder.Entity<Doctor>()
                .HasData(new List<Doctor>
                {
                    new Doctor { Id = 7, Name ="Alix Ingry",              Specialization = "Urology",         Img = "doctor7.jpg"   ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00) },
                    new Doctor { Id = 8, Name ="Wally Hake",              Specialization = "Dermatology",     Img = "doctor8.jpg"   ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 9, Name = "Jock Readwood",          Specialization = "Gastroenterology",Img = "doctor9.jpg"   ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 10,Name = "Abby Abbitt",            Specialization = "Cardiology",      Img = "doctor10.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 11,Name = "Leroy Orbell",           Specialization = "Oncology",        Img = "doctor11.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 12,Name = "Darrick Hall",           Specialization = "Endocrinology",   Img = "doctor12.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 13,Name = "Lilyan McKechnie",       Specialization = "Urology",         Img = "doctor13.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 14,Name = "Flem Bolzen",            Specialization = "Neurology",       Img = "doctor14.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 15,Name = "Ginnifer Grinter",       Specialization = "Neurology",       Img = "doctor15.jpg"  ,StartWork=new TimeOnly(19,00)   ,EndWork=new TimeOnly(01,00)},
                    new Doctor { Id = 16,Name = "Jarrod Killshaw",        Specialization = "Pediatrics",      Img = "doctor16.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 17,Name = "Florri Newport",         Specialization = "Endocrinology",   Img = "doctor17.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 18,Name = "Cornie Horbart",         Specialization = "Orthopedics",     Img = "doctor18.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 19,Name = "Lucila Villa",           Specialization = "Dermatology",     Img = "doctor19.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 20,Name = "Michaeline Van der Brug",Specialization = "Urology",         Img = "doctor20.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 21,Name = "Pinchas Probets",        Specialization = "Psychiatry",      Img = "doctor21.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 22,Name = "Bengt Hassey",           Specialization = "Endocrinology",   Img = "doctor22.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 23,Name = "Alikee Puvia",           Specialization = "Urology",         Img = "doctor23.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 24,Name = "Chelsey Hundell",        Specialization = "Cardiology",      Img = "doctor24.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)},
                    new Doctor { Id = 25,Name = "Cate Bloxam",            Specialization = "Cardiology",      Img = "doctor25.jpg"  ,StartWork=new TimeOnly(19,00)   ,EndWork=new TimeOnly(01,00)},
                    new Doctor { Id = 26,Name = "Rochester Oliver-Paull", Specialization = "Gastroenterology",Img = "doctor26.jpg"  ,StartWork=new TimeOnly(10,00)   ,EndWork=new TimeOnly(18,00)}
                });
        }
    }
}
