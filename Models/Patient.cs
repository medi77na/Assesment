using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment.Models;

[Table("patients")]
public class Patient : Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("weight")]
    public double Weight { get; set; }

    [Column("height")]
    public double Height { get; set; }

    [Column("allergies")]
    public string? Allergies { get; set; }
}