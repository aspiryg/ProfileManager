using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateScoringSystem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "ScoringSystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "ScoringSystems");

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
    }
}
