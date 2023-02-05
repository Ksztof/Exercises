using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntersysJs.Migrations
{
    /// <inheritdoc />
    public partial class initialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Tomasz", "Krawczyk" },
                    { 2, "Maria", "Wiśniewski" },
                    { 3, "Katarzyna", "Krawczyk" },
                    { 4, "Katarzyna", "Wójcik" },
                    { 5, "Jan", "Kowalski" },
                    { 6, "Anna", "Nowak" },
                    { 7, "Anna", "Wójcik" },
                    { 8, "Jan", "Wiśniewski" },
                    { 9, "Tomasz", "Krawczyk" },
                    { 10, "Anna", "Wójcik" },
                    { 11, "Jan", "Wiśniewski" },
                    { 12, "Katarzyna", "Kowalski" },
                    { 13, "Tomasz", "Wójcik" },
                    { 14, "Jan", "Krawczyk" },
                    { 15, "Jan", "Wójcik" },
                    { 16, "Maria", "Nowak" },
                    { 17, "Jan", "Nowak" },
                    { 18, "Katarzyna", "Krawczyk" },
                    { 19, "Maria", "Wiśniewski" },
                    { 20, "Maria", "Krawczyk" },
                    { 21, "Anna", "Krawczyk" },
                    { 22, "Katarzyna", "Wójcik" },
                    { 23, "Jan", "Kowalski" },
                    { 24, "Tomasz", "Krawczyk" },
                    { 25, "Tomasz", "Wójcik" },
                    { 26, "Katarzyna", "Wiśniewski" },
                    { 27, "Anna", "Wójcik" },
                    { 28, "Jan", "Wójcik" },
                    { 29, "Tomasz", "Nowak" },
                    { 30, "Anna", "Wiśniewski" },
                    { 31, "Maria", "Nowak" },
                    { 32, "Anna", "Wiśniewski" },
                    { 33, "Maria", "Nowak" },
                    { 34, "Tomasz", "Wiśniewski" },
                    { 35, "Jan", "Nowak" },
                    { 36, "Anna", "Nowak" },
                    { 37, "Katarzyna", "Kowalski" },
                    { 38, "Anna", "Kowalski" },
                    { 39, "Maria", "Krawczyk" },
                    { 40, "Maria", "Nowak" },
                    { 41, "Tomasz", "Wiśniewski" },
                    { 42, "Tomasz", "Wiśniewski" },
                    { 43, "Katarzyna", "Wójcik" },
                    { 44, "Anna", "Krawczyk" },
                    { 45, "Jan", "Wójcik" },
                    { 46, "Katarzyna", "Wiśniewski" },
                    { 47, "Anna", "Kowalski" },
                    { 48, "Tomasz", "Krawczyk" },
                    { 49, "Anna", "Wójcik" },
                    { 50, "Anna", "Wiśniewski" },
                    { 51, "Tomasz", "Wójcik" },
                    { 52, "Tomasz", "Kowalski" },
                    { 53, "Tomasz", "Wiśniewski" },
                    { 54, "Jan", "Nowak" },
                    { 55, "Tomasz", "Wójcik" },
                    { 56, "Maria", "Wiśniewski" },
                    { 57, "Anna", "Nowak" },
                    { 58, "Katarzyna", "Wójcik" },
                    { 59, "Katarzyna", "Wójcik" },
                    { 60, "Katarzyna", "Kowalski" },
                    { 61, "Maria", "Nowak" },
                    { 62, "Maria", "Wójcik" },
                    { 63, "Anna", "Nowak" },
                    { 64, "Anna", "Wiśniewski" },
                    { 65, "Tomasz", "Kowalski" },
                    { 66, "Maria", "Kowalski" },
                    { 67, "Jan", "Kowalski" },
                    { 68, "Maria", "Wiśniewski" },
                    { 69, "Katarzyna", "Wiśniewski" },
                    { 70, "Katarzyna", "Wiśniewski" },
                    { 71, "Anna", "Nowak" },
                    { 72, "Anna", "Wiśniewski" },
                    { 73, "Maria", "Kowalski" },
                    { 74, "Katarzyna", "Wójcik" },
                    { 75, "Anna", "Wiśniewski" },
                    { 76, "Katarzyna", "Wiśniewski" },
                    { 77, "Katarzyna", "Kowalski" },
                    { 78, "Maria", "Kowalski" },
                    { 79, "Jan", "Krawczyk" },
                    { 80, "Tomasz", "Nowak" },
                    { 81, "Anna", "Krawczyk" },
                    { 82, "Anna", "Wójcik" },
                    { 83, "Tomasz", "Krawczyk" },
                    { 84, "Maria", "Wiśniewski" },
                    { 85, "Tomasz", "Krawczyk" },
                    { 86, "Jan", "Wójcik" },
                    { 87, "Tomasz", "Wiśniewski" },
                    { 88, "Katarzyna", "Nowak" },
                    { 89, "Maria", "Krawczyk" },
                    { 90, "Tomasz", "Wiśniewski" },
                    { 91, "Tomasz", "Wójcik" },
                    { 92, "Jan", "Nowak" },
                    { 93, "Maria", "Wiśniewski" },
                    { 94, "Katarzyna", "Wójcik" },
                    { 95, "Jan", "Kowalski" },
                    { 96, "Jan", "Krawczyk" },
                    { 97, "Katarzyna", "Wiśniewski" },
                    { 98, "Anna", "Wiśniewski" },
                    { 99, "Tomasz", "Wiśniewski" },
                    { 100, "Jan", "Wójcik" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
