using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateStage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StageID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NGOs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_NGOs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageGroupParent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActualAssignee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Stages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StageStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_StageStatuses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "StageStatuses",
                columns: new[] { "ID", "Color", "CreatedBy", "CreatedDate", "Description", "Icon", "IsActive", "IsDeleted", "IsModified", "ModifiedBy", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2107), "", "Pending", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2104), "Pending" },
                    { 2, "Primary", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2114), "", "InProgress", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2113), "In Progress" },
                    { 3, "Success", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2119), "", "Completed", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2118), "Completed" },
                    { 4, "Danger", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2124), "", "Cancelled", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2122), "Cancelled" },
                    { 5, "Danger", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2129), "", "Rejected", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2127), "Rejected" },
                    { 6, "Success", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2134), "", "Approved", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2132), "Approved" },
                    { 7, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2139), "", "OnHold", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2137), "On Hold" },
                    { 8, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2144), "", "NotStarted", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2142), "Not Started" },
                    { 9, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2149), "", "NotApplicable", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2147), "Not Applicable" },
                    { 10, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2154), "", "NotRequired", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2152), "Not Required" },
                    { 11, "Warning", "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2158), "", "NotAvailable", true, false, false, "", new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2157), "Not Available" }
                });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1869), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1883), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(1881) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NGOs");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "StageStatuses");

            migrationBuilder.DropColumn(
                name: "StageID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2115), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 7, 22, 19, 45, 42, 771, DateTimeKind.Local).AddTicks(2128) });
        }
    }
}
