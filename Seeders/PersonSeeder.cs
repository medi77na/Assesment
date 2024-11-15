using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class PersonSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasData(
                new Person
                {
                    Id = 1,
                    Name = "John",
                    LastName = "Doe",
                    DocumentNumber = 12345678,
                    PhoneNumber = 987654321,
                    DateBirth = new DateOnly(1990, 5, 20),
                    Email = "john.doe@example.com",
                    Password = "hashedpassword1",
                    IdRole = 2
                },
                new Person
                {
                    Id = 2,
                    Name = "Jane",
                    LastName = "Smith",
                    DocumentNumber = 87654321,
                    PhoneNumber = 912345678,
                    DateBirth = new DateOnly(1985, 11, 15),
                    Email = "jane.smith@example.com",
                    Password = "hashedpassword2",
                    IdRole = 2
                },
                new Person
                {
                    Id = 3,
                    Name = "Alice",
                    LastName = "Johnson",
                    DocumentNumber = 12312312,
                    PhoneNumber = 998877665,
                    DateBirth = new DateOnly(1995, 7, 10),
                    Email = "alice.johnson@example.com",
                    Password = "hashedpassword3",
                    IdRole = 2
                },
                new Person
                {
                    Id = 4,
                    Name = "Bob",
                    LastName = "Brown",
                    DocumentNumber = 45645645,
                    PhoneNumber = 987123456,
                    DateBirth = new DateOnly(1988, 3, 25),
                    Email = "bob.brown@example.com",
                    Password = "hashedpassword4",
                    IdRole = 2
                },
                new Person
                {
                    Id = 5,
                    Name = "Charlie",
                    LastName = "Davis",
                    DocumentNumber = 78978978,
                    PhoneNumber = 976543210,
                    DateBirth = new DateOnly(1992, 9, 5),
                    Email = "charlie.davis@example.com",
                    Password = "hashedpassword5",
                    IdRole = 3
                },
                new Person
                {
                    Id = 6,
                    Name = "Emily",
                    LastName = "Wilson",
                    DocumentNumber = 65432123,
                    PhoneNumber = 965874123,
                    DateBirth = new DateOnly(1993, 2, 18),
                    Email = "emily.wilson@example.com",
                    Password = "hashedpassword6",
                    IdRole = 3
                },
                new Person
                {
                    Id = 7,
                    Name = "Daniel",
                    LastName = "Taylor",
                    DocumentNumber = 11223344,
                    PhoneNumber = 914578965,
                    DateBirth = new DateOnly(1987, 4, 12),
                    Email = "daniel.taylor@example.com",
                    Password = "hashedpassword7",
                    IdRole = 3
                },
                new Person
                {
                    Id = 8,
                    Name = "Sophia",
                    LastName = "Anderson",
                    DocumentNumber = 55667788,
                    PhoneNumber = 987412365,
                    DateBirth = new DateOnly(1999, 8, 21),
                    Email = "sophia.anderson@example.com",
                    Password = "hashedpassword8",
                    IdRole = 3
                },
                new Person
                {
                    Id = 9,
                    Name = "Michael",
                    LastName = "Thomas",
                    DocumentNumber = 99887766,
                    PhoneNumber = 923456789,
                    DateBirth = new DateOnly(1991, 10, 3),
                    Email = "michael.thomas@example.com",
                    Password = "hashedpassword9",
                    IdRole = 1
                },
                new Person
                {
                    Id = 10,
                    Name = "Olivia",
                    LastName = "Harris",
                    DocumentNumber = 44332211,
                    PhoneNumber = 965432198,
                    DateBirth = new DateOnly(1996, 12, 29),
                    Email = "olivia.harris@example.com",
                    Password = "hashedpassword10",
                    IdRole = 1
                }
            );
    }
}
