using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStageTable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAssigned",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentStage",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNextStage",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOverdue",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStarted",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StageNumber",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8061), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8350), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 7, 27, 22, 53, 48, 419, DateTimeKind.Local).AddTicks(7242) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssigned",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsCurrentStage",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsNextStage",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsOverdue",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IsStarted",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "StageNumber",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(76), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(84), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(91), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 7, 27, 0, 15, 19, 763, DateTimeKind.Local).AddTicks(102) });
        }
    }
}
