using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_String.Migrations
{
    /// <inheritdoc />
    public partial class updateDoctorAndDocotrForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "DoctorForms");

            migrationBuilder.AddColumn<string>(
                name: "DayAppointment",
                table: "DoctorForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeAppoint",
                table: "DoctorForms",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayAppointment",
                table: "DoctorForms");

            migrationBuilder.DropColumn(
                name: "TimeAppoint",
                table: "DoctorForms");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "DoctorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
