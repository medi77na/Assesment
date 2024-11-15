using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class AppointmentSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>()
            .HasData(
                new Appointment
                {
                    Id = 1,
                    IdDoctor = 1,
                    IdPatient = 1,
                    IdSpecialty = 1,
                    ReasonConsultation = "Routine check-up",
                    Status = true,
                    Date = new DateOnly(2024, 12, 5),
                    Time = new TimeOnly(10, 30),
                    Comments = "Patient requested a general health check-up."
                },
                new Appointment
                {
                    Id = 2,
                    IdDoctor = 2,
                    IdPatient = 2,
                    IdSpecialty = 3,
                    ReasonConsultation = "Knee pain",
                    Status = true,
                    Date = new DateOnly(2024, 12, 6),
                    Time = new TimeOnly(15, 0),
                    Comments = "Patient reports chronic knee pain over the past month."
                },
                new Appointment
                {
                    Id = 3,
                    IdDoctor = 3,
                    IdPatient = 3,
                    IdSpecialty = 2,
                    ReasonConsultation = "Skin rash",
                    Status = false,
                    Date = new DateOnly(2024, 12, 7),
                    Time = new TimeOnly(11, 0),
                    Comments = "Appointment cancelled by the patient."
                },
                new Appointment
                {
                    Id = 4,
                    IdDoctor = 4,
                    IdPatient = 4,
                    IdSpecialty = 4,
                    ReasonConsultation = "Back pain",
                    Status = true,
                    Date = new DateOnly(2024, 12, 8),
                    Time = new TimeOnly(9, 0),
                    Comments = "Patient experiences discomfort while sitting for long hours."
                }
            );
    }
}
