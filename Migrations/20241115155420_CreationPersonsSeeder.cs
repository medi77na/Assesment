using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assesment.Migrations
{
    /// <inheritdoc />
    public partial class CreationPersonsSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "date_birth", "document_number", "email", "id_role", "last_name", "name", "password", "phone_number" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 5, 20), 12345678, "john.doe@example.com", 2, "Doe", "John", "hashedpassword1", 987654321 },
                    { 2, new DateOnly(1985, 11, 15), 87654321, "jane.smith@example.com", 2, "Smith", "Jane", "hashedpassword2", 912345678 },
                    { 3, new DateOnly(1995, 7, 10), 12312312, "alice.johnson@example.com", 2, "Johnson", "Alice", "hashedpassword3", 998877665 },
                    { 4, new DateOnly(1988, 3, 25), 45645645, "bob.brown@example.com", 2, "Brown", "Bob", "hashedpassword4", 987123456 },
                    { 5, new DateOnly(1992, 9, 5), 78978978, "charlie.davis@example.com", 3, "Davis", "Charlie", "hashedpassword5", 976543210 },
                    { 6, new DateOnly(1993, 2, 18), 65432123, "emily.wilson@example.com", 3, "Wilson", "Emily", "hashedpassword6", 965874123 },
                    { 7, new DateOnly(1987, 4, 12), 11223344, "daniel.taylor@example.com", 3, "Taylor", "Daniel", "hashedpassword7", 914578965 },
                    { 8, new DateOnly(1999, 8, 21), 55667788, "sophia.anderson@example.com", 3, "Anderson", "Sophia", "hashedpassword8", 987412365 },
                    { 9, new DateOnly(1991, 10, 3), 99887766, "michael.thomas@example.com", 1, "Thomas", "Michael", "hashedpassword9", 923456789 },
                    { 10, new DateOnly(1996, 12, 29), 44332211, "olivia.harris@example.com", 1, "Harris", "Olivia", "hashedpassword10", 965432198 }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "id_person", "id_shedule" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "allergies", "height", "id_person", "weight" },
                values: new object[,]
                {
                    { 1, "Pollen", 1.75, 5, 70.5 },
                    { 2, "None", 1.8, 6, 82.299999999999997 },
                    { 3, "Peanuts", 1.6799999999999999, 7, 65.0 },
                    { 4, "Dust", 1.8500000000000001, 8, 90.700000000000003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 8);
        }
    }
}
