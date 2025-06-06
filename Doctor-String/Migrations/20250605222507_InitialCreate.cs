﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doctor_String.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specialization = table.Column<string>(type: "varchar(50)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorForms_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, "doctor1.jpg", "Dr. John Smith", "Cardiology" },
                    { 2, "doctor2.jpg", "Dr. Sarah Johnson", "Pediatrics" },
                    { 3, "doctor4.jpg", "Dr. Emily Davis", "Dermatology" },
                    { 4, "doctor3.jpg", "Dr. Michael Lee", "Orthopedics" },
                    { 5, "doctor5.jpg", "Dr. William Clark", "Neurology" },
                    { 6, "doctor6.jpg", "Dr. Hasnna ahmed", "Hurt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorForms_DoctorId",
                table: "DoctorForms",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorForms");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
