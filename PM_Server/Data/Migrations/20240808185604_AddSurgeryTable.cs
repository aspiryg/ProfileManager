using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSurgeryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurgeryRequired",
                table: "SEAssessments");

            migrationBuilder.AddColumn<int>(
                name: "SurgeryId",
                table: "SEAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Surgeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurgeryCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurgeryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurgeryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurgeryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurgeryCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Surgeries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2068), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2078), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2088), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2098), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2109), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2119), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1767), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1792), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1811), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1822), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.InsertData(
                table: "Surgeries",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "ModifiedBy", "ModifiedDate", "SurgeryCategory", "SurgeryCode", "SurgeryDescription", "SurgeryName", "SurgeryType" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2186), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2182), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 1", "" },
                    { 2, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2196), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2193), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 2", "" },
                    { 3, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2205), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2202), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 3", "" },
                    { 4, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2213), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2210), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 4", "" },
                    { 5, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2222), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2219), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 5", "" },
                    { 6, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2230), true, false, false, "", new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2228), "", new Guid("00000000-0000-0000-0000-000000000000"), "", "Surgery 6", "" }
                });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1196), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1214), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1222), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.CreateIndex(
                name: "IX_SEAssessments_SurgeryId",
                table: "SEAssessments",
                column: "SurgeryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SEAssessments_Surgeries_SurgeryId",
                table: "SEAssessments",
                column: "SurgeryId",
                principalTable: "Surgeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SEAssessments_Surgeries_SurgeryId",
                table: "SEAssessments");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropIndex(
                name: "IX_SEAssessments_SurgeryId",
                table: "SEAssessments");

            migrationBuilder.DropColumn(
                name: "SurgeryId",
                table: "SEAssessments");

            migrationBuilder.AddColumn<string>(
                name: "SurgeryRequired",
                table: "SEAssessments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6495), new Guid("c73572d9-0cb8-44ab-81f5-820c886d0016") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6521), new Guid("d9025b22-2cee-4ebb-a7de-765bff3f1b9b") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6531), new Guid("9620cf5b-45b7-4f60-a304-6366bd5c3227") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6541), new Guid("fb52c351-2643-4213-b396-14d785a5a518") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6550), new Guid("ce3317ba-4e87-463b-ac9a-ce43299345c5") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6560), new Guid("a2ac9cf7-9f47-4b52-a8c2-5fba47554447") });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6230), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5806), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(5820) });
        }
    }
}
