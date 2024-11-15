using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assesment.Migrations
{
    /// <inheritdoc />
    public partial class CreationScheduleSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shedules",
                columns: new[] { "id", "end_date", "end_time", "start_date", "start_time" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 11, 30), new TimeOnly(14, 0, 0), new DateOnly(2024, 11, 20), new TimeOnly(8, 0, 0) },
                    { 2, new DateOnly(2024, 12, 5), new TimeOnly(20, 0, 0), new DateOnly(2024, 11, 20), new TimeOnly(14, 0, 0) },
                    { 3, new DateOnly(2024, 11, 28), new TimeOnly(17, 0, 0), new DateOnly(2024, 11, 22), new TimeOnly(9, 0, 0) },
                    { 4, new DateOnly(2024, 12, 1), new TimeOnly(16, 0, 0), new DateOnly(2024, 11, 25), new TimeOnly(10, 0, 0) },
                    { 5, new DateOnly(2024, 12, 10), new TimeOnly(13, 0, 0), new DateOnly(2024, 11, 27), new TimeOnly(7, 0, 0) },
                    { 6, new DateOnly(2024, 12, 15), new TimeOnly(18, 0, 0), new DateOnly(2024, 12, 1), new TimeOnly(12, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "shedules",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
