using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class ScheduleSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Schedule>()
            .HasData(
                new Schedule
                {
                    Id = 1,
                    StartDate = new DateOnly(2024, 11, 20),
                    EndDate = new DateOnly(2024, 11, 30),
                    StartTime = new TimeOnly(8, 0),  // 8:00 AM
                    EndTime = new TimeOnly(14, 0)   // 2:00 PM
                },
                new Schedule
                {
                    Id = 2,
                    StartDate = new DateOnly(2024, 11, 20),
                    EndDate = new DateOnly(2024, 12, 5),
                    StartTime = new TimeOnly(14, 0), // 2:00 PM
                    EndTime = new TimeOnly(20, 0)   // 8:00 PM
                },
                new Schedule
                {
                    Id = 3,
                    StartDate = new DateOnly(2024, 11, 22),
                    EndDate = new DateOnly(2024, 11, 28),
                    StartTime = new TimeOnly(9, 0),  // 9:00 AM
                    EndTime = new TimeOnly(17, 0)   // 5:00 PM
                },
                new Schedule
                {
                    Id = 4,
                    StartDate = new DateOnly(2024, 11, 25),
                    EndDate = new DateOnly(2024, 12, 1),
                    StartTime = new TimeOnly(10, 0), // 10:00 AM
                    EndTime = new TimeOnly(16, 0)   // 4:00 PM
                },
                new Schedule
                {
                    Id = 5,
                    StartDate = new DateOnly(2024, 11, 27),
                    EndDate = new DateOnly(2024, 12, 10),
                    StartTime = new TimeOnly(7, 0),  // 7:00 AM
                    EndTime = new TimeOnly(13, 0)   // 1:00 PM
                },
                new Schedule
                {
                    Id = 6,
                    StartDate = new DateOnly(2024, 12, 1),
                    EndDate = new DateOnly(2024, 12, 15),
                    StartTime = new TimeOnly(12, 0), // 12:00 PM
                    EndTime = new TimeOnly(18, 0)   // 6:00 PM
                }
            );
    }
}
