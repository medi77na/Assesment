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
                    IdDoctor = 1,                 // Doctor con ID 1
                    IdPatient = 5,                // Paciente con ID 5
                    IdSpecialty = 1,              // Especialidad con ID 1
                    ReasonConsultation = "Routine check-up", // Revisión rutinaria
                    Status = true,                // Activa
                    Date = new DateOnly(2024, 12, 5),  // Fecha de la cita
                    Time = new TimeOnly(10, 30),  // 10:30 AM
                    Comments = "Patient requested a general health check-up."
                },
                new Appointment
                {
                    Id = 2,
                    IdDoctor = 2,                 // Doctor con ID 2
                    IdPatient = 6,                // Paciente con ID 6
                    IdSpecialty = 3,              // Especialidad con ID 3
                    ReasonConsultation = "Knee pain", // Dolor de rodilla
                    Status = true,                // Activa
                    Date = new DateOnly(2024, 12, 6),  // Fecha de la cita
                    Time = new TimeOnly(15, 0),   // 3:00 PM
                    Comments = "Patient reports chronic knee pain over the past month."
                },
                new Appointment
                {
                    Id = 3,
                    IdDoctor = 3,                 // Doctor con ID 3
                    IdPatient = 7,                // Paciente con ID 7
                    IdSpecialty = 2,              // Especialidad con ID 2
                    ReasonConsultation = "Skin rash", // Erupción cutánea
                    Status = false,               // Cancelada
                    Date = new DateOnly(2024, 12, 7),  // Fecha de la cita
                    Time = new TimeOnly(11, 0),   // 11:00 AM
                    Comments = "Appointment cancelled by the patient."
                },
                new Appointment
                {
                    Id = 4,
                    IdDoctor = 4,                 // Doctor con ID 4
                    IdPatient = 8,                // Paciente con ID 8
                    IdSpecialty = 4,              // Especialidad con ID 4
                    ReasonConsultation = "Back pain", // Dolor de espalda
                    Status = true,                // Activa
                    Date = new DateOnly(2024, 12, 8),  // Fecha de la cita
                    Time = new TimeOnly(9, 0),    // 9:00 AM
                    Comments = "Patient experiences discomfort while sitting for long hours."
                }
            );
    }
}
