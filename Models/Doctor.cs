using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment.Models;

[Table("doctors")]
public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_shedule")]
    public int IdShedule { get; set; }

    [ForeignKey(nameof(IdShedule))]
    public Schedule? Schedule { get; set; }

    [Column("id_person")]
    public int IdPerson { get; set; }

    [ForeignKey(nameof(IdPerson))]
    public Person Person { get; set; }
}