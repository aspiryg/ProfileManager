using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateScoringSystem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaseId",
                table: "ScoringSystems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "ScoringSystems",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "ScoringSystems",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ScoringSystems",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "ScoringSystems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5702), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5597), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5635), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5778), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Surgeries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5326), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 8, 11, 15, 21, 40, 789, DateTimeKind.Local).AddTicks(5329) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "ScoringSystems");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "ScoringSystems");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "ScoringSystems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ScoringSystems");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ScoringSystems");

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
    }
}
