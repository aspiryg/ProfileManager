using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 7, 23, 23, 17, 41, 211, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 7, 23, 23, 17, 41, 210, DateTimeKind.Local).AddTicks(9968) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1926), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1683), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1693), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 7, 23, 19, 38, 30, 693, DateTimeKind.Local).AddTicks(1714) });
        }
    }
}
