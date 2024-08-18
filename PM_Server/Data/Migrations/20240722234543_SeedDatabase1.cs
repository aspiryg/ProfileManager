using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsDeleted", "IsModified", "ModifiedBy", "ModifiedDate", "Type" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2091), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2088), "Referrer" },
                    { 2, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2100), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2098), "Social Worker" },
                    { 3, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2106), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2104), "Medical Examiner" },
                    { 4, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2110), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2109), "HealthCare Service Providers" },
                    { 5, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2115), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2114), "Financial Supporter" },
                    { 6, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2120), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2119), "Medical Missions" },
                    { 7, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2125), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2123), "Medi-financial service provider" },
                    { 8, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2130), "", true, false, false, "", new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2128), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
