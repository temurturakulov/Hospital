using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_DoctorSpecialties_SpecialtyIdId",
                table: "TimeTables");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_AspNetUsers_UserIdId",
                table: "TimeTables");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "TimeTables",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SpecialtyIdId",
                table: "TimeTables",
                newName: "SpecialtyId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTables_UserIdId",
                table: "TimeTables",
                newName: "IX_TimeTables_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTables_SpecialtyIdId",
                table: "TimeTables",
                newName: "IX_TimeTables_SpecialtyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_DoctorSpecialties_SpecialtyId",
                table: "TimeTables",
                column: "SpecialtyId",
                principalTable: "DoctorSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_AspNetUsers_UserId",
                table: "TimeTables",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_DoctorSpecialties_SpecialtyId",
                table: "TimeTables");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_AspNetUsers_UserId",
                table: "TimeTables");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TimeTables",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "TimeTables",
                newName: "SpecialtyIdId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTables_UserId",
                table: "TimeTables",
                newName: "IX_TimeTables_UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTables_SpecialtyId",
                table: "TimeTables",
                newName: "IX_TimeTables_SpecialtyIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_DoctorSpecialties_SpecialtyIdId",
                table: "TimeTables",
                column: "SpecialtyIdId",
                principalTable: "DoctorSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_AspNetUsers_UserIdId",
                table: "TimeTables",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
