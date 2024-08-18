using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PM_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSocioEconomicAssessment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocioeconomicAssessmentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    NationalityID = table.Column<int>(type: "int", nullable: false),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingFamilyMembers = table.Column<int>(type: "int", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityToAffordEssentialNeeds = table.Column<bool>(type: "bit", nullable: false),
                    UNRWARegistered = table.Column<bool>(type: "bit", nullable: false),
                    UNRWARegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UNCHRRegistered = table.Column<bool>(type: "bit", nullable: false),
                    UNCHRRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOSARegistered = table.Column<bool>(type: "bit", nullable: false),
                    MOSARegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherRegistered = table.Column<bool>(type: "bit", nullable: false),
                    OtherRegistrationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFamilyMembers = table.Column<int>(type: "int", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false),
                    NumberOfDependents = table.Column<int>(type: "int", nullable: false),
                    IsHeadOfHousehold = table.Column<bool>(type: "bit", nullable: false),
                    HasDisability = table.Column<bool>(type: "bit", nullable: false),
                    DisabilityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisabilityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisabilitySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasHealthInsurance = table.Column<bool>(type: "bit", nullable: false),
                    InsuranceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuranceCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsurancePolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurgeryRequired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_SEAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SEAssessments_Nationalities_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SEAssessments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "ModifiedBy", "ModifiedDate", "NationalityCode", "NationalityName" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3704), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3699), new Guid("b7f59154-e80e-46d2-afbd-f503b14864be"), "Afghan" },
                    { 2, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3715), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3711), new Guid("322f9f7e-0924-4283-9735-eb6fe521cc26"), "Syrian" },
                    { 3, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3725), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3721), new Guid("cdf9d183-cc72-4ace-8173-c214df0326f7"), "Palestinian" },
                    { 4, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3734), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3731), new Guid("0aa51782-8e03-4b80-9fa0-5cca399932f6"), "Lebanese" },
                    { 5, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3807), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3803), new Guid("dd67a808-a874-4997-84a0-a6a874fe87cc"), "Egyptian" },
                    { 6, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3817), true, false, false, "", new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3814), new Guid("4c4d6b73-2e65-414b-b081-a53860aa8122"), "Iraqi" }
                });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3499), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "StageStatuses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3567), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "StageTypes",
                keyColumn: "StageID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3001), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 8, 7, 15, 0, 45, 788, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.CreateIndex(
                name: "IX_SEAssessments_NationalityID",
                table: "SEAssessments",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_SEAssessments_PatientID",
                table: "SEAssessments",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SEAssessments");

            migrationBuilder.DropTable(
                name: "Nationalities");

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
    }
}
