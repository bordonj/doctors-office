using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsOffice.Migrations
{
    public partial class SpecialtyAgainUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId1",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_DoctorId1",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "Specialties");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Specialties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_DoctorId",
                table: "Specialties",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_DoctorId",
                table: "Specialties");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "Specialties",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId1",
                table: "Specialties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_DoctorId1",
                table: "Specialties",
                column: "DoctorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Doctors_DoctorId1",
                table: "Specialties",
                column: "DoctorId1",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
