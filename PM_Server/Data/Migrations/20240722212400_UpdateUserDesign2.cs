using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserDesign2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_SocialWorkers_SocialWorkerId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "SocialWorkers");

            migrationBuilder.RenameColumn(
                name: "SocialWorkerId",
                table: "Patients",
                newName: "SocialWorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_SocialWorkerId",
                table: "Patients",
                newName: "IX_Patients_SocialWorkerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_UserProfiles_SocialWorkerID",
                table: "Patients",
                column: "SocialWorkerID",
                principalTable: "UserProfiles",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_UserProfiles_SocialWorkerID",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "SocialWorkerID",
                table: "Patients",
                newName: "SocialWorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_SocialWorkerID",
                table: "Patients",
                newName: "IX_Patients_SocialWorkerId");

            migrationBuilder.CreateTable(
                name: "SocialWorkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialWorkers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_SocialWorkers_SocialWorkerId",
                table: "Patients",
                column: "SocialWorkerId",
                principalTable: "SocialWorkers",
                principalColumn: "Id");
        }
    }
}
