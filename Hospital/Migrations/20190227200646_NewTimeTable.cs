using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class NewTimeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialtyName",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "UserFName",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "UserLName",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "UserSName",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "AuthId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserYear",
                table: "TimeTables",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "DoctorSpecialtyId",
                table: "AspNetUsers",
                newName: "RoleIdId");

            migrationBuilder.AlterColumn<string>(
                name: "UserIdId",
                table: "TimeTables",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialtyIdId",
                table: "TimeTables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthIdId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorSpecialtyIdId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_SpecialtyIdId",
                table: "TimeTables",
                column: "SpecialtyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_UserIdId",
                table: "TimeTables",
                column: "UserIdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AuthIdId",
                table: "AspNetUsers",
                column: "AuthIdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoctorSpecialtyIdId",
                table: "AspNetUsers",
                column: "DoctorSpecialtyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleIdId",
                table: "AspNetUsers",
                column: "RoleIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Authorizations_AuthIdId",
                table: "AspNetUsers",
                column: "AuthIdId",
                principalTable: "Authorizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DoctorSpecialties_DoctorSpecialtyIdId",
                table: "AspNetUsers",
                column: "DoctorSpecialtyIdId",
                principalTable: "DoctorSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Roles_RoleIdId",
                table: "AspNetUsers",
                column: "RoleIdId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Authorizations_AuthIdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DoctorSpecialties_DoctorSpecialtyIdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Roles_RoleIdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_DoctorSpecialties_SpecialtyIdId",
                table: "TimeTables");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_AspNetUsers_UserIdId",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_TimeTables_SpecialtyIdId",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_TimeTables_UserIdId",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AuthIdId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DoctorSpecialtyIdId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleIdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SpecialtyIdId",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "AuthIdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorSpecialtyIdId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "TimeTables",
                newName: "UserYear");

            migrationBuilder.RenameColumn(
                name: "RoleIdId",
                table: "AspNetUsers",
                newName: "DoctorSpecialtyId");

            migrationBuilder.AlterColumn<string>(
                name: "UserYear",
                table: "TimeTables",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialtyName",
                table: "TimeTables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserFName",
                table: "TimeTables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserLName",
                table: "TimeTables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserSName",
                table: "TimeTables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
