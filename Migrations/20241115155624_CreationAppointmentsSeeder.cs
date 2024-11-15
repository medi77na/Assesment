using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assesment.Migrations
{
    /// <inheritdoc />
    public partial class CreationAppointmentsSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "comments", "date", "id_doctor", "id_patient", "id_specialty", "reason_for_consultation", "status", "time" },
                values: new object[,]
                {
                    { 1, "Patient requested a general health check-up.", new DateOnly(2024, 12, 5), 1, 1, 1, "Routine check-up", true, new TimeOnly(10, 30, 0) },
                    { 2, "Patient reports chronic knee pain over the past month.", new DateOnly(2024, 12, 6), 2, 2, 3, "Knee pain", true, new TimeOnly(15, 0, 0) },
                    { 3, "Appointment cancelled by the patient.", new DateOnly(2024, 12, 7), 3, 3, 2, "Skin rash", false, new TimeOnly(11, 0, 0) },
                    { 4, "Patient experiences discomfort while sitting for long hours.", new DateOnly(2024, 12, 8), 4, 4, 4, "Back pain", true, new TimeOnly(9, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
