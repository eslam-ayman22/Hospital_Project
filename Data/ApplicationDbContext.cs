using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Models.Doctor> doctors { get; set; }
        public DbSet<Models.Patient> patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json" , true ,reloadOnChange:true)
                .Build();

            var connection = builder.GetConnectionString("Defaultconnection");

            optionsBuilder.UseSqlServer(connection);

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /************Add Data To Doctor Table*******************/
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(new Doctor
            {
                Id = 1,
                Name = "Dr. John Smith",
                Specialization = "Cardiology",
                Img = "doctor1.jpg"
            });
            doctors.Add(new Doctor()
            {
                Id = 2,
                Name = "Dr. Sarah Johnson",
                Specialization = "Pediatrics",
                Img = "doctor2.jpg"
            });
            doctors.Add(new Doctor()
            {
                Id = 3,
                Name = "Dr. Emily Davis",
                Specialization = "Dermatology",
                Img = "doctor4.jpg"
            });
            doctors.Add(new Doctor()
            {
                Id = 4,
                Name = "Dr. Michael Lee",
                Specialization = "Orthopedics",
                Img = "doctor3.jpg"
            });
            doctors.Add(new Doctor()
            {
                Id = 5,
                Name = "Dr. William Clark",
                Specialization = "Neurology",
                Img = "doctor5.jpg"
            });
           
            modelBuilder.Entity<Doctor>().HasData(doctors); 
        }
    }
}
