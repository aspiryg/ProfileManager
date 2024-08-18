using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStageTypes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "StageTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AssignedBy",
                table: "StageTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "StageTypes",
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
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6363), 1 });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6376), 2 });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6384), 3 });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6391), 4 });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6399), 5 });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "AssignedBy", "AssignedTo", "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { "", "", new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 8, 7, 22, 10, 2, 287, DateTimeKind.Local).AddTicks(6407), 6 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedBy",
                table: "StageTypes");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "StageTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Order",
                table: "StageTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3699), new Guid("b7f59154-e80e-46d2-afbd-f503b14864be") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3711), new Guid("322f9f7e-0924-4283-9735-eb6fe521cc26") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3725), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3721), new Guid("cdf9d183-cc72-4ace-8173-c214df0326f7") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3731), new Guid("0aa51782-8e03-4b80-9fa0-5cca399932f6") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3803), new Guid("dd67a808-a874-4997-84a0-a6a874fe87cc") });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "NationalityCode" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3814), new Guid("4c4d6b73-2e65-414b-b081-a53860aa8122") });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3499), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3567), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3570), "" });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3582), "" });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3590), "" });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3597), "" });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3603), "" });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Order" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3610), "" });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3001), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3035) });
        }
    }
}
