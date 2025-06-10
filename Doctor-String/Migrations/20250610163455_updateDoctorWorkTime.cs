using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_String.Migrations
{
    /// <inheritdoc />
    public partial class updateDoctorWorkTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndWork",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartWork",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndWork", "Specialization", "StartWork" },
                values: new object[] { new TimeOnly(1, 0, 0), "Neurology", new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(1, 0, 0), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(1, 0, 0), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndWork", "StartWork" },
                values: new object[] { new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWork",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "StartWork",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Specialization",
                value: "Hurt");
        }
    }
}
