using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class SpecialtySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Specialty>()
            .HasData(
                new Specialty
                {
                    Id = 1,
                    Name = "Cardiology"
                },
                new Specialty
                {
                    Id = 2,
                    Name = "Pediatrics"
                },
                new Specialty
                {
                    Id = 3,
                    Name = "Dermatology"
                },
                new Specialty
                {
                    Id = 4,
                    Name = "Neurology"
                },
                new Specialty
                {
                    Id = 5,
                    Name = "Orthopedics"
                }
            );
    }
}