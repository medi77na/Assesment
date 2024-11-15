using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class PatientSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Patient>()
        .HasData(
            new Patient
            {
                Id = 1,
                Weight = 70.5,          
                Height = 1.75,          
                Allergies = "Pollen",
                IdPerson = 5
            },
            new Patient
            {
                Id = 2,
                Weight = 82.3,          
                Height = 1.80,          
                Allergies = "None",
                IdPerson = 6 
            },
            new Patient
            {
                Id = 3,
                Weight = 65.0,          
                Height = 1.68,          
                Allergies = "Peanuts",
                IdPerson = 7 
            },
            new Patient
            {
                Id = 4,
                Weight = 90.7,          
                Height = 1.85,          
                Allergies = "Dust",
                IdPerson = 8
            }
        );
}


}