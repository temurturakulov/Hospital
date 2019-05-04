using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class Doctor_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_DoctorSpecialties_SpecialtyIdId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserIdId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_SpecialtyIdId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserIdId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Doctors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SpecialtyIdId",
                table: "Doctors",
                newName: "SpecialtyId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Doctors",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Doctors",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "Doctors",
                newName: "SpecialtyIdId");

            migrationBuilder.AlterColumn<string>(
                name: "UserIdId",
                table: "Doctors",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialtyIdId",
                table: "Doctors",
                column: "SpecialtyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserIdId",
                table: "Doctors",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_DoctorSpecialties_SpecialtyIdId",
                table: "Doctors",
                column: "SpecialtyIdId",
                principalTable: "DoctorSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserIdId",
                table: "Doctors",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
