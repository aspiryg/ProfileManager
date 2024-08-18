using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStageTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Patient_Id",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Patient_Id",
                table: "Stages");

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3836), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3841), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3846), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3944), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3949), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3481), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3501), new DateTime(2024, 7, 27, 0, 9, 2, 700, DateTimeKind.Local).AddTicks(3499) });
        }
    }
}
