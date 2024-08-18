using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddGene1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmploymentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4613), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4629), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4436), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4458), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4462), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4552), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4561), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4067), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4086), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 8, 12, 22, 19, 6, 567, DateTimeKind.Local).AddTicks(4089) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentStatuses");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4458), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4463), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4202), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4225), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4256), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4312), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4533), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3914), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 8, 11, 18, 33, 2, 450, DateTimeKind.Local).AddTicks(3936) });
        }
    }
}
