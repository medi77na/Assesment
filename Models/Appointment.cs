using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment.Models;

[Table("appointments")]
public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_doctor")]
    public int IdDoctor { get; set; }

    [Column("id_patient")]
    public int IdPatient { get; set; }

    [Column("id_specialty")]
    public int IdSpecialty { get; set; }

    [Column("reason_for_consultation")]
    public string? ReasonConsultation { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [Column("date")]
    public DateOnly Date { get; set; }

    [Column("time")]
    public TimeOnly Time { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }

    [ForeignKey(nameof(IdDoctor))]
    public Doctor? Doctor { get; set; }

    [ForeignKey(nameof(IdPatient))]
    public Patient? Patient { get; set; }

    [ForeignKey(nameof(IdSpecialty))]
    public Specialty? Specialty { get; set; }
}