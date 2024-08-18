using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateStageForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Stages",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Stages_PatientID",
                table: "Stages",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages");

            migrationBuilder.DropIndex(
                name: "IX_Stages_PatientID",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Stages");

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2107), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2114), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2119), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2129), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2158), new DateTime(2024, 7, 22, 21, 18, 40, 798, DateTimeKind.Local).AddTicks(2157) });

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
    }
}
