using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class DoctorSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>()
            .HasData(
                new Doctor
                {
                    Id = 1,
                    IdPerson = 1,
                    IdShedule = 1
                },
                new Doctor
                {
                    Id = 2,
                    IdPerson = 2,
                    IdShedule = 2
                },
                new Doctor
                {
                    Id = 3,
                    IdPerson = 3,
                    IdShedule = 3
                },
                new Doctor
                {
                    Id = 4,
                    IdPerson = 4,
                    IdShedule = 4
                }
            );
    }
}