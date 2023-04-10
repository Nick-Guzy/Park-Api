using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkApi.Migrations
{
    public partial class NewInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NationalPark",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NationalParkName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NationalParkLocation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalPark", x => x.NationalParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatePark",
                columns: table => new
                {
                    StateParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateParkName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StateParkLocation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePark", x => x.StateParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "NationalPark",
                columns: new[] { "NationalParkId", "NationalParkLocation", "NationalParkName" },
                values: new object[,]
                {
                    { 1, "National1", "National Name1" },
                    { 2, "National2", "National Name2" },
                    { 3, "National3", "National Name3" },
                    { 4, "National4", "National Name4" },
                    { 5, "National5", "National Name5" }
                });

            migrationBuilder.InsertData(
                table: "StatePark",
                columns: new[] { "StateParkId", "StateParkLocation", "StateParkName" },
                values: new object[,]
                {
                    { 1, "State1", "State Name1" },
                    { 2, "State2", "State Name2" },
                    { 3, "State3", "State Name3" },
                    { 4, "State4", "State Name4" },
                    { 5, "State5", "State Name5" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Password" },
                values: new object[] { "admin1", "JoeMama", "password1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalPark");

            migrationBuilder.DropTable(
                name: "StatePark");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
