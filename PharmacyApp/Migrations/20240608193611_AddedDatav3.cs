using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmacyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedDatav3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", "Star" },
                    { 4, new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eminem", "Marshall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Fajny" });
        }
    }
}
