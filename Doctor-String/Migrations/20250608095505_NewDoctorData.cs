using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doctor_String.Migrations
{
    /// <inheritdoc />
    public partial class NewDoctorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 7, "doctor7.jpg", "Alix Ingry", "Urology" },
                    { 8, "doctor8.jpg", "Wally Hake", "Dermatology" },
                    { 9, "doctor9.jpg", "Jock Readwood", "Gastroenterology" },
                    { 10, "doctor10.jpg", "Abby Abbitt", "Cardiology" },
                    { 11, "doctor11.jpg", "Leroy Orbell", "Oncology" },
                    { 12, "doctor12.jpg", "Darrick Hall", "Endocrinology" },
                    { 13, "doctor13.jpg", "Lilyan McKechnie", "Urology" },
                    { 14, "doctor14.jpg", "Flem Bolzen", "Neurology" },
                    { 15, "doctor15.jpg", "Ginnifer Grinter", "Neurology" },
                    { 16, "doctor16.jpg", "Jarrod Killshaw", "Pediatrics" },
                    { 17, "doctor17.jpg", "Florri Newport", "Endocrinology" },
                    { 18, "doctor18.jpg", "Cornie Horbart", "Orthopedics" },
                    { 19, "doctor19.jpg", "Lucila Villa", "Dermatology" },
                    { 20, "doctor20.jpg", "Michaeline Van der Brug", "Urology" },
                    { 21, "doctor21.jpg", "Pinchas Probets", "Psychiatry" },
                    { 22, "doctor22.jpg", "Bengt Hassey", "Endocrinology" },
                    { 23, "doctor23.jpg", "Alikee Puvia", "Urology" },
                    { 24, "doctor24.jpg", "Chelsey Hundell", "Cardiology" },
                    { 25, "doctor25.jpg", "Cate Bloxam", "Cardiology" },
                    { 26, "doctor26.jpg", "Rochester Oliver-Paull", "Gastroenterology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
