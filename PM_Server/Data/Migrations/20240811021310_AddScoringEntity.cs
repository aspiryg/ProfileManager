using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddScoringEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoringSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoringSystemCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Oprator = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ScoringSystems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2709), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2714), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2728), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2733), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2738), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2802), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2806), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2977), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2988), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2423), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2433), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2442), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 8, 10, 22, 13, 9, 404, DateTimeKind.Local).AddTicks(2450) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoringSystems");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2119) });

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

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2213), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 8, 8, 14, 56, 2, 852, DateTimeKind.Local).AddTicks(2228) });

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
        }
    }
}
