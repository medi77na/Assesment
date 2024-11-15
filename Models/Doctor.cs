using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment.Models;

[Table("doctors")]
public class Doctor : Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_shedule")]
    public int IdShedule { get; set; }

    [Column("id_role")]
    public int IdRole { get; set; }

    [ForeignKey(nameof(IdShedule))]
    public Schedule? Schedule { get; set; }

    [ForeignKey(nameof(IdRole))]
    public Role? Role { get; set; }
}