using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStageTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages");

            migrationBuilder.AlterColumn<int>(
                name: "PatientID",
                table: "Stages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "PatientID",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6217), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6283), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6356), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6384), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5611), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 7, 27, 0, 0, 53, 827, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.AddForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
