using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystemDB.Migrations
{
    /// <inheritdoc />
    public partial class PlayerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Weigth = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Heigth = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    JerseyNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
