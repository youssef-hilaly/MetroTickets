using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MetroTickets.DataService.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstId = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Edges_Stations_FirstId",
                        column: x => x.FirstId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Edges_Stations_SecondId",
                        column: x => x.SecondId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Helwan" },
                    { 2, "Ain Helwan" },
                    { 3, "Helwan University" },
                    { 4, "Wadi Hof" },
                    { 5, "Hadayek Helwan" },
                    { 6, "El Maasara" },
                    { 7, "Tora El Asmant" },
                    { 8, "Kozzika" },
                    { 9, "Tora El Balad" },
                    { 10, "Sakanat El Maadi" },
                    { 11, "Maadi" },
                    { 12, "Hadayek El Maadi" },
                    { 13, "Dar El Salam" },
                    { 14, "El Zahraa" },
                    { 15, "Mar Girgis" },
                    { 16, "El Malek El Saleh" },
                    { 17, "Al Sayeda Zeinab" },
                    { 18, "Saad Zaghloul" },
                    { 19, "Sadat" },
                    { 20, "Nasser" },
                    { 21, "Orabi" },
                    { 22, "Al Shohadaa" },
                    { 23, "Ghamra" },
                    { 24, "El Demerdash" },
                    { 25, "Manshiet El Sadr" },
                    { 26, "Kobri El Qobba" },
                    { 27, "Hammamat El Qobba" },
                    { 28, "Saray El Qobba" },
                    { 29, "Hadayeq El Zaitoun" },
                    { 30, "Helmeyet El Zaitoun" },
                    { 31, "El Matareyya" },
                    { 32, "Ain Shams" },
                    { 33, "Ezbet El Nakhl" },
                    { 34, "El Marg" },
                    { 35, "New El Marg" }
                });

            migrationBuilder.InsertData(
                table: "Edges",
                columns: new[] { "Id", "Cost", "FirstId", "SecondId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 3 },
                    { 3, 1, 3, 4 },
                    { 4, 1, 4, 5 },
                    { 5, 1, 5, 6 },
                    { 6, 1, 6, 7 },
                    { 7, 1, 7, 8 },
                    { 8, 1, 8, 9 },
                    { 9, 1, 9, 10 },
                    { 10, 1, 10, 11 },
                    { 11, 1, 11, 12 },
                    { 12, 1, 12, 13 },
                    { 13, 1, 13, 14 },
                    { 14, 1, 14, 15 },
                    { 15, 1, 15, 16 },
                    { 16, 1, 16, 17 },
                    { 17, 1, 17, 18 },
                    { 18, 1, 18, 19 },
                    { 19, 1, 19, 20 },
                    { 20, 1, 20, 21 },
                    { 21, 1, 21, 22 },
                    { 22, 1, 22, 23 },
                    { 23, 1, 23, 24 },
                    { 24, 1, 24, 25 },
                    { 25, 1, 25, 26 },
                    { 26, 1, 26, 27 },
                    { 27, 1, 27, 28 },
                    { 28, 1, 28, 29 },
                    { 29, 1, 29, 30 },
                    { 30, 1, 30, 31 },
                    { 31, 1, 31, 32 },
                    { 32, 1, 32, 33 },
                    { 33, 1, 33, 34 },
                    { 34, 1, 34, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Edges_FirstId",
                table: "Edges",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_Edges_SecondId",
                table: "Edges",
                column: "SecondId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edges");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
