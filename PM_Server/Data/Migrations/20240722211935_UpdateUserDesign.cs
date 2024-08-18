using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Referrers_ReferrerId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Referrers",
                table: "Referrers");

            migrationBuilder.RenameTable(
                name: "Referrers",
                newName: "UserProfiles");

            migrationBuilder.RenameColumn(
                name: "ReferrerId",
                table: "Patients",
                newName: "ReferrerID");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ReferrerId",
                table: "Patients",
                newName: "IX_Patients_ReferrerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserProfiles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "UserProfiles",
                newName: "UserType");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "UserProfiles",
                newName: "UserID");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "UserProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserProfiles",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_UserProfiles_ReferrerID",
                table: "Patients",
                column: "ReferrerID",
                principalTable: "UserProfiles",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_UserProfiles_ReferrerID",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "Referrers");

            migrationBuilder.RenameColumn(
                name: "ReferrerID",
                table: "Patients",
                newName: "ReferrerId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ReferrerID",
                table: "Patients",
                newName: "IX_Patients_ReferrerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Referrers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Referrers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Referrers",
                newName: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Referrers",
                table: "Referrers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Referrers_ReferrerId",
                table: "Patients",
                column: "ReferrerId",
                principalTable: "Referrers",
                principalColumn: "Id");
        }
    }
}
