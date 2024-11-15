using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment.Models;

public class Person
{
    [Column("name")]
    public string? Name { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }

    [Column("document_number")]
    public int DocumentNumber { get; set; }

    [Column("phone_number")]
    public int PhoneNumber { get; set; }

    [Column("date_birth")]
    public DateOnly DateBirth { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("password")]
    public string? Password { get; set; }
}