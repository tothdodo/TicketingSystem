using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketingSystemDB.Migrations
{
    /// <inheritdoc />
    public partial class TwentyTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowId", "SeatNumber" },
                values: new object[,]
                {
                    { 1019, 100, 19 },
                    { 1020, 100, 20 },
                    { 1021, 100, 21 },
                    { 1022, 100, 22 },
                    { 1119, 101, 19 },
                    { 1120, 101, 20 },
                    { 1121, 101, 21 },
                    { 1122, 101, 22 },
                    { 1219, 102, 19 },
                    { 1220, 102, 20 },
                    { 1221, 102, 21 },
                    { 1222, 102, 22 },
                    { 1319, 103, 19 },
                    { 1320, 103, 20 },
                    { 1321, 103, 21 },
                    { 1322, 103, 22 },
                    { 1419, 104, 19 },
                    { 1420, 104, 20 },
                    { 1421, 104, 21 },
                    { 1422, 104, 22 },
                    { 1519, 105, 19 },
                    { 1520, 105, 20 },
                    { 1521, 105, 21 },
                    { 1522, 105, 22 },
                    { 1619, 106, 19 },
                    { 1620, 106, 20 },
                    { 1621, 106, 21 },
                    { 1622, 106, 22 },
                    { 1719, 107, 19 },
                    { 1720, 107, 20 },
                    { 1721, 107, 21 },
                    { 1722, 107, 22 },
                    { 3019, 300, 19 },
                    { 3020, 300, 20 },
                    { 3021, 300, 21 },
                    { 3022, 300, 22 },
                    { 3119, 301, 19 },
                    { 3120, 301, 20 },
                    { 3121, 301, 21 },
                    { 3122, 301, 22 },
                    { 3219, 302, 19 },
                    { 3220, 302, 20 },
                    { 3221, 302, 21 },
                    { 3222, 302, 22 },
                    { 3319, 303, 19 },
                    { 3320, 303, 20 },
                    { 3321, 303, 21 },
                    { 3322, 303, 22 },
                    { 3419, 304, 19 },
                    { 3420, 304, 20 },
                    { 3421, 304, 21 },
                    { 3422, 304, 22 },
                    { 3519, 305, 19 },
                    { 3520, 305, 20 },
                    { 3521, 305, 21 },
                    { 3522, 305, 22 },
                    { 3619, 306, 19 },
                    { 3620, 306, 20 },
                    { 3621, 306, 21 },
                    { 3622, 306, 22 },
                    { 3719, 307, 19 },
                    { 3720, 307, 20 },
                    { 3721, 307, 21 },
                    { 3722, 307, 22 }
                });

            migrationBuilder.InsertData(
                table: "GameSeats",
                columns: new[] { "GameId", "SeatId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1019, "Available", null },
                    { 2, 1019, "Available", null },
                    { 3, 1019, "Available", null },
                    { 1, 1020, "Available", null },
                    { 2, 1020, "Available", null },
                    { 3, 1020, "Available", null },
                    { 1, 1021, "Available", null },
                    { 2, 1021, "Available", null },
                    { 3, 1021, "Available", null },
                    { 1, 1022, "Available", null },
                    { 2, 1022, "Available", null },
                    { 3, 1022, "Available", null },
                    { 1, 1119, "Available", null },
                    { 2, 1119, "Available", null },
                    { 3, 1119, "Available", null },
                    { 1, 1120, "Available", null },
                    { 2, 1120, "Available", null },
                    { 3, 1120, "Available", null },
                    { 1, 1121, "Available", null },
                    { 2, 1121, "Available", null },
                    { 3, 1121, "Available", null },
                    { 1, 1122, "Available", null },
                    { 2, 1122, "Available", null },
                    { 3, 1122, "Available", null },
                    { 1, 1219, "Available", null },
                    { 2, 1219, "Available", null },
                    { 3, 1219, "Available", null },
                    { 1, 1220, "Available", null },
                    { 2, 1220, "Available", null },
                    { 3, 1220, "Available", null },
                    { 1, 1221, "Available", null },
                    { 2, 1221, "Available", null },
                    { 3, 1221, "Available", null },
                    { 1, 1222, "Available", null },
                    { 2, 1222, "Available", null },
                    { 3, 1222, "Available", null },
                    { 1, 1319, "Available", null },
                    { 2, 1319, "Available", null },
                    { 3, 1319, "Available", null },
                    { 1, 1320, "Available", null },
                    { 2, 1320, "Available", null },
                    { 3, 1320, "Available", null },
                    { 1, 1321, "Available", null },
                    { 2, 1321, "Available", null },
                    { 3, 1321, "Available", null },
                    { 1, 1322, "Available", null },
                    { 2, 1322, "Available", null },
                    { 3, 1322, "Available", null },
                    { 1, 1419, "Available", null },
                    { 2, 1419, "Available", null },
                    { 3, 1419, "Available", null },
                    { 1, 1420, "Available", null },
                    { 2, 1420, "Available", null },
                    { 3, 1420, "Available", null },
                    { 1, 1421, "Available", null },
                    { 2, 1421, "Available", null },
                    { 3, 1421, "Available", null },
                    { 1, 1422, "Available", null },
                    { 2, 1422, "Available", null },
                    { 3, 1422, "Available", null },
                    { 1, 1519, "Available", null },
                    { 2, 1519, "Available", null },
                    { 3, 1519, "Available", null },
                    { 1, 1520, "Available", null },
                    { 2, 1520, "Available", null },
                    { 3, 1520, "Available", null },
                    { 1, 1521, "Available", null },
                    { 2, 1521, "Available", null },
                    { 3, 1521, "Available", null },
                    { 1, 1522, "Available", null },
                    { 2, 1522, "Available", null },
                    { 3, 1522, "Available", null },
                    { 1, 1619, "Available", null },
                    { 2, 1619, "Available", null },
                    { 3, 1619, "Available", null },
                    { 1, 1620, "Available", null },
                    { 2, 1620, "Available", null },
                    { 3, 1620, "Available", null },
                    { 1, 1621, "Available", null },
                    { 2, 1621, "Available", null },
                    { 3, 1621, "Available", null },
                    { 1, 1622, "Available", null },
                    { 2, 1622, "Available", null },
                    { 3, 1622, "Available", null },
                    { 1, 1719, "Available", null },
                    { 2, 1719, "Available", null },
                    { 3, 1719, "Available", null },
                    { 1, 1720, "Available", null },
                    { 2, 1720, "Available", null },
                    { 3, 1720, "Available", null },
                    { 1, 1721, "Available", null },
                    { 2, 1721, "Available", null },
                    { 3, 1721, "Available", null },
                    { 1, 1722, "Available", null },
                    { 2, 1722, "Available", null },
                    { 3, 1722, "Available", null },
                    { 1, 3019, "Available", null },
                    { 2, 3019, "Available", null },
                    { 3, 3019, "Available", null },
                    { 1, 3020, "Available", null },
                    { 2, 3020, "Available", null },
                    { 3, 3020, "Available", null },
                    { 1, 3021, "Available", null },
                    { 2, 3021, "Available", null },
                    { 3, 3021, "Available", null },
                    { 1, 3022, "Available", null },
                    { 2, 3022, "Available", null },
                    { 3, 3022, "Available", null },
                    { 1, 3119, "Available", null },
                    { 2, 3119, "Available", null },
                    { 3, 3119, "Available", null },
                    { 1, 3120, "Available", null },
                    { 2, 3120, "Available", null },
                    { 3, 3120, "Available", null },
                    { 1, 3121, "Available", null },
                    { 2, 3121, "Available", null },
                    { 3, 3121, "Available", null },
                    { 1, 3122, "Available", null },
                    { 2, 3122, "Available", null },
                    { 3, 3122, "Available", null },
                    { 1, 3219, "Available", null },
                    { 2, 3219, "Available", null },
                    { 3, 3219, "Available", null },
                    { 1, 3220, "Available", null },
                    { 2, 3220, "Available", null },
                    { 3, 3220, "Available", null },
                    { 1, 3221, "Available", null },
                    { 2, 3221, "Available", null },
                    { 3, 3221, "Available", null },
                    { 1, 3222, "Available", null },
                    { 2, 3222, "Available", null },
                    { 3, 3222, "Available", null },
                    { 1, 3319, "Available", null },
                    { 2, 3319, "Available", null },
                    { 3, 3319, "Available", null },
                    { 1, 3320, "Available", null },
                    { 2, 3320, "Available", null },
                    { 3, 3320, "Available", null },
                    { 1, 3321, "Available", null },
                    { 2, 3321, "Available", null },
                    { 3, 3321, "Available", null },
                    { 1, 3322, "Available", null },
                    { 2, 3322, "Available", null },
                    { 3, 3322, "Available", null },
                    { 1, 3419, "Available", null },
                    { 2, 3419, "Available", null },
                    { 3, 3419, "Available", null },
                    { 1, 3420, "Available", null },
                    { 2, 3420, "Available", null },
                    { 3, 3420, "Available", null },
                    { 1, 3421, "Available", null },
                    { 2, 3421, "Available", null },
                    { 3, 3421, "Available", null },
                    { 1, 3422, "Available", null },
                    { 2, 3422, "Available", null },
                    { 3, 3422, "Available", null },
                    { 1, 3519, "Available", null },
                    { 2, 3519, "Available", null },
                    { 3, 3519, "Available", null },
                    { 1, 3520, "Available", null },
                    { 2, 3520, "Available", null },
                    { 3, 3520, "Available", null },
                    { 1, 3521, "Available", null },
                    { 2, 3521, "Available", null },
                    { 3, 3521, "Available", null },
                    { 1, 3522, "Available", null },
                    { 2, 3522, "Available", null },
                    { 3, 3522, "Available", null },
                    { 1, 3619, "Available", null },
                    { 2, 3619, "Available", null },
                    { 3, 3619, "Available", null },
                    { 1, 3620, "Available", null },
                    { 2, 3620, "Available", null },
                    { 3, 3620, "Available", null },
                    { 1, 3621, "Available", null },
                    { 2, 3621, "Available", null },
                    { 3, 3621, "Available", null },
                    { 1, 3622, "Available", null },
                    { 2, 3622, "Available", null },
                    { 3, 3622, "Available", null },
                    { 1, 3719, "Available", null },
                    { 2, 3719, "Available", null },
                    { 3, 3719, "Available", null },
                    { 1, 3720, "Available", null },
                    { 2, 3720, "Available", null },
                    { 3, 3720, "Available", null },
                    { 1, 3721, "Available", null },
                    { 2, 3721, "Available", null },
                    { 3, 3721, "Available", null },
                    { 1, 3722, "Available", null },
                    { 2, 3722, "Available", null },
                    { 3, 3722, "Available", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 1722 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 1722 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 1722 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3019 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3020 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3021 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3022 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3119 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3120 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3121 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3122 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3219 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3220 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3221 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3222 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3319 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3320 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3321 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3322 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3419 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3420 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3421 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3422 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3519 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3520 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3521 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3522 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3619 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3620 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3621 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3622 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3719 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3720 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3721 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 1, 3722 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 2, 3722 });

            migrationBuilder.DeleteData(
                table: "GameSeats",
                keyColumns: new[] { "GameId", "SeatId" },
                keyValues: new object[] { 3, 3722 });

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3519);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3520);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3521);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3522);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3619);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3620);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3621);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3622);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3719);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3720);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3721);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3722);
        }
    }
}
