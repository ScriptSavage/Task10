using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddeAllTablesV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Medicaments_IdMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_IdPresciption",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.RenameTable(
                name: "PrescriptionMedicament",
                newName: "PrescriptionMedicaments");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicament_IdPresciption",
                table: "PrescriptionMedicaments",
                newName: "IX_PrescriptionMedicaments_IdPresciption");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicaments",
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPresciption" });

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Medicaments_IdMedicament",
                table: "PrescriptionMedicaments",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPresciption",
                table: "PrescriptionMedicaments",
                column: "IdPresciption",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Medicaments_IdMedicament",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPresciption",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicaments",
                table: "PrescriptionMedicaments");

            migrationBuilder.RenameTable(
                name: "PrescriptionMedicaments",
                newName: "PrescriptionMedicament");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicaments_IdPresciption",
                table: "PrescriptionMedicament",
                newName: "IX_PrescriptionMedicament_IdPresciption");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament",
                columns: new[] { "IdMedicament", "IdPresciption" });

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Medicaments_IdMedicament",
                table: "PrescriptionMedicament",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_IdPresciption",
                table: "PrescriptionMedicament",
                column: "IdPresciption",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
