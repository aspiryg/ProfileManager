using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddPropToPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Patients",
                newName: "ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5774), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5801), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5817), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5904), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5911), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5995), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6002), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6015), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 7, 25, 21, 38, 33, 428, DateTimeKind.Local).AddTicks(5264) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Patients",
                newName: "Address");

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

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2354), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2362), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2378), new DateTime(2024, 7, 25, 20, 16, 13, 887, DateTimeKind.Local).AddTicks(2381) });

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
    }
}
