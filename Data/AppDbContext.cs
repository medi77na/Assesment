using Assesment.Models;
using Assesment.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Data;


public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        RoleSeeder.Seed(modelBuilder);
        SpecialtySeeder.Seed(modelBuilder);
        ScheduleSeeder.Seed(modelBuilder);
        PersonSeeder.Seed(modelBuilder);
        PatientSeeder.Seed(modelBuilder);
        DoctorSeeder.Seed(modelBuilder);
        AppointmentSeeder.Seed(modelBuilder);
        

        //modelBuilder.Entity<Person>()
        //     .HasIndex(d => d.Email)
        //     .IsUnique();
    }
}