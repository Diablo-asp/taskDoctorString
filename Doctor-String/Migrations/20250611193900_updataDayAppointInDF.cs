using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_String.Migrations
{
    /// <inheritdoc />
    public partial class updataDayAppointInDF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DayAppointment",
                table: "DoctorForms",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DayAppointment",
                table: "DoctorForms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
