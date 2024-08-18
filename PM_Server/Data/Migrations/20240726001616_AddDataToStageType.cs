using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToStageType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StageTypes",
                columns: table => new
                {
                    StageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DurationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageTypes", x => x.StageID);
                });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2118), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2214), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2256), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.InsertData(
                table: "StageTypes",
                columns: new[] { "StageID", "Color", "CreatedBy", "CreatedDate", "Description", "Duration", "DurationType", "DurationUnit", "Group", "Icon", "IsActive", "IsDeleted", "IsModified", "ModifiedBy", "ModifiedDate", "Name", "Order", "Parent", "Responsible" },
                values: new object[,]
                {
                    { 1, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2332), "", 0, "", "Day", "", "Intake", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2336), "Intake", "", "", "Referrer" },
                    { 2, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2345), "", 7, "", "Day", "", "Assessment", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2348), "SocioEconomic Assessment", "", "", "Social Worker" },
                    { 3, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2354), "", 7, "", "Day", "", "Medical", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2357), "Medical Assessment", "", "", "Medical Examiner" },
                    { 4, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2362), "", 7, "", "Day", "", "Treatment", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2365), "Treatment Plan", "", "", "HealthCare Service Providers" },
                    { 5, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2370), "", 7, "", "Day", "", "Financial", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2372), "Payment Stage", "", "", "Medi-financial service provider" },
                    { 6, "Green", "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2378), "", 0, "", "Day", "", "End", true, false, false, "", new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2381), "End the process", "", "", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1549), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(1632) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StageTypes");

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
    }
}
