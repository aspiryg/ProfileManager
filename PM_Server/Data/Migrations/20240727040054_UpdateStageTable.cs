using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages");

            migrationBuilder.AlterColumn<int>(
                name: "StageOrder",
                table: "Stages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PatientID",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageStatusID",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "StageStatusID",
                table: "Stages");

            migrationBuilder.AlterColumn<string>(
                name: "StageOrder",
                table: "Stages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Stages_Patients_PatientID",
                table: "Stages",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID");
        }
    }
}
