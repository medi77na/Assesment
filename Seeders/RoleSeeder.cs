using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;


public class RoleSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>()
            .HasData(
                new Role
                {
                    Id = 1,
                    Name = "Administrator"
                },
                new Role
                {
                    Id = 2,
                    Name = "Doctor"
                },
                new Role
                {
                    Id = 3,
                    Name = "Patient"
                }
            );
    }
}