using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPresciption",
                table: "PrescriptionMedicaments");

            migrationBuilder.RenameColumn(
                name: "IdPresciption",
                table: "PrescriptionMedicaments",
                newName: "IdPrescription");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicaments_IdPresciption",
                table: "PrescriptionMedicaments",
                newName: "IX_PrescriptionMedicaments_IdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPrescription",
                table: "PrescriptionMedicaments",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPrescription",
                table: "PrescriptionMedicaments");

            migrationBuilder.RenameColumn(
                name: "IdPrescription",
                table: "PrescriptionMedicaments",
                newName: "IdPresciption");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicaments_IdPrescription",
                table: "PrescriptionMedicaments",
                newName: "IX_PrescriptionMedicaments_IdPresciption");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_IdPresciption",
                table: "PrescriptionMedicaments",
                column: "IdPresciption",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
