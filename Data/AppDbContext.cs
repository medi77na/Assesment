using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Data;


public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Specialty> Specialties { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        /*Se colocan los seeders necesarios.
        |
        |
        |
        */
        // modelBuilder.Entity<Person>()
        //     .HasIndex(d => d.Email)
        //     .IsUnique();
    }
}