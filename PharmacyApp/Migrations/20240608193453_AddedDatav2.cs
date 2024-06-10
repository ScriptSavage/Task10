using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedDatav2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[] { 4, "billy@example.com", "Billy", "Butcher" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);
        }
    }
}
