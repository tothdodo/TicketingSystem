using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystemDB.Migrations
{
    /// <inheritdoc />
    public partial class services : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuyEnds", "BuyStarts" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
