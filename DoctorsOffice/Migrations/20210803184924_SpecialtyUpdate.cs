using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsOffice.Migrations
{
    public partial class SpecialtyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Specialties",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId1",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_DoctorId1",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "Specialties");
        }
    }
}
