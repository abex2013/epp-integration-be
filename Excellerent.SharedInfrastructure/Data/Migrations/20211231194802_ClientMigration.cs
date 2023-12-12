using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Excellerent.SharedInfrastructure.Data.Migrations
{
    public partial class ClientMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    ContactNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ResumeUpload = table.Column<string>(type: "text", nullable: true),
                    ProfilePictureUpload = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    ClientStatus = table.Column<string>(type: "text", nullable: true),
                    ManagerAssigned = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ClientStatus",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStatus", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    DataType = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "DeviceDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    SubCategoryGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyDeviceCode = table.Column<string>(type: "text", nullable: true),
                    DeviceName = table.Column<string>(type: "text", nullable: true),
                    BusinessUnit = table.Column<string>(type: "text", nullable: true),
                    IsWorking = table.Column<string>(type: "text", nullable: true),
                    AllocateTo = table.Column<string>(type: "text", nullable: true),
                    DeviceClassificationGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Purchaser = table.Column<string>(type: "text", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "text", nullable: true),
                    Manufacturer = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: true),
                    Warranty = table.Column<string>(type: "text", nullable: true),
                    WarrantyEndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDetails", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "EducationProgrammes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProgrammes", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    StateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    SubCityZone = table.Column<string>(type: "text", nullable: true),
                    Woreda = table.Column<string>(type: "text", nullable: true),
                    HouseNumber = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyAddresses", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    FatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    GrandFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    MobilePhone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Phone1 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Phone2 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    PersonalEmail = table.Column<string>(type: "text", nullable: false),
                    PersonalEmail2 = table.Column<string>(type: "text", nullable: true),
                    PersonalEmail3 = table.Column<string>(type: "text", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "FieldOfStudie",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOfStudie", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "JobRequirment",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobDescriptionName = table.Column<string>(type: "text", nullable: true),
                    JobBrief = table.Column<string>(type: "text", nullable: true),
                    JobResponsiblity = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRequirment", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionCode = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    KeyValue = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "text", nullable: true),
                    ParentCode = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "PositionToApply",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionToApply", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ProficiencyLevel",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyLevel", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusName = table.Column<string>(type: "text", nullable: true),
                    AllowResource = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "SkillSet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSet", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FromDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TotalHours = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheet", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ClientDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    SalesPersonGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    ClientStatusGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDetails", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ClientDetails_ClientStatus_ClientStatusGuid",
                        column: x => x.ClientStatusGuid,
                        principalTable: "ClientStatus",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DutyBranches",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyBranches", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_DutyBranches_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContactsModel",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    GrandFatherName = table.Column<string>(type: "text", nullable: true),
                    Relationship = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    phoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    phoneNumber3 = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    email2 = table.Column<string>(type: "text", nullable: true),
                    email3 = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    stateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    subCityZone = table.Column<string>(type: "text", nullable: true),
                    woreda = table.Column<string>(type: "text", nullable: true),
                    houseNumber = table.Column<string>(type: "text", nullable: true),
                    postalCode = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContactsModel", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_EmergencyContactsModel_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Nationalities_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    StateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    SubCityZone = table.Column<string>(type: "text", nullable: true),
                    Woreda = table.Column<string>(type: "text", nullable: true),
                    HouseNumber = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_PersonalAddresses_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Tel = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicantId = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationProgrammeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Institution = table.Column<string>(type: "text", nullable: true),
                    FieldOfStudyId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateTo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    OtherFieldOfStudy = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Educations_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_EducationProgrammes_EducationProgrammeId",
                        column: x => x.EducationProgrammeId,
                        principalTable: "EducationProgrammes",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_FieldOfStudie_FieldOfStudyId",
                        column: x => x.FieldOfStudyId,
                        principalTable: "FieldOfStudie",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantAreaOfInterest",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionToApplyID = table.Column<Guid>(type: "uuid", nullable: false),
                    LuPositionToApplyGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ProficiencyLevelID = table.Column<Guid>(type: "uuid", nullable: false),
                    YearsOfExpierence = table.Column<int>(type: "integer", nullable: false),
                    MonthOfExpierence = table.Column<int>(type: "integer", nullable: false),
                    PrimarySkillSetID = table.Column<string>(type: "text", nullable: true),
                    SecondarySkillSetID = table.Column<string>(type: "text", nullable: true),
                    OtherSkillSet = table.Column<string>(type: "text", nullable: true),
                    ApplicantId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantAreaOfInterest", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_PositionToApply_LuPositionToApplyGu~",
                        column: x => x.LuPositionToApplyGuid,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_ProficiencyLevel_ProficiencyLevelID",
                        column: x => x.ProficiencyLevelID,
                        principalTable: "ProficiencyLevel",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    RelationshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    DoB = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_Relationship_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationship",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LUPositionSkillSet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    LUPositionToApplyId = table.Column<Guid>(type: "uuid", nullable: false),
                    LUSkillSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUPositionSkillSet", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_LUPositionSkillSet_PositionToApply_LUPositionToApplyId",
                        column: x => x.LUPositionToApplyId,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LUPositionSkillSet_SkillSet_LUSkillSetId",
                        column: x => x.LUSkillSetId,
                        principalTable: "SkillSet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillPositionAssociation",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionToApplyID = table.Column<int>(type: "integer", nullable: false),
                    luPositionToApplyGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    PrimarySkillSetID = table.Column<int>(type: "integer", nullable: false),
                    skillSetGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    SecondarySkillSetID = table.Column<int>(type: "integer", nullable: false),
                    OtherSkillSet = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPositionAssociation", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_SkillPositionAssociation_PositionToApply_luPositionToApplyG~",
                        column: x => x.luPositionToApplyGuid,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillPositionAssociation_SkillSet_skillSetGuid",
                        column: x => x.skillSetGuid,
                        principalTable: "SkillSet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeEntry",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    Hour = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    TimesheetGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntry", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_TimeEntry_TimeSheet_TimesheetGuid",
                        column: x => x.TimesheetGuid,
                        principalTable: "TimeSheet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetAprovals",
                columns: table => new
                {
                    TimesheetId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetAprovals", x => new { x.TimesheetId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_TimesheetAprovals_TimeSheet_TimesheetId",
                        column: x => x.TimesheetId,
                        principalTable: "TimeSheet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupSetPermissions",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSetPermissions", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_GroupSetPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupSetPermissions_UserGroups_GroupSetId",
                        column: x => x.GroupSetId,
                        principalTable: "UserGroups",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Affliation = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_BillingAddresses_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientContacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactPersonName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberPrefix = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ClientContacts_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperatingAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_OperatingAddresses_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ProjectType = table.Column<int>(type: "integer", nullable: false),
                    SupervisorGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectStatusGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Project_ClientDetails_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_ProjectStatus_ProjectStatusGuid",
                        column: x => x.ProjectStatusGuid,
                        principalTable: "ProjectStatus",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrganizations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    DutyBranch = table.Column<string>(type: "text", nullable: false),
                    BranchGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompaynEmail = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmploymentType = table.Column<string>(type: "text", nullable: false),
                    BusinessUnit = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    ReportingManager = table.Column<string>(type: "text", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrganizations", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_EmployeeOrganizations_DutyBranches_BranchGuid",
                        column: x => x.BranchGuid,
                        principalTable: "DutyBranches",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeOrganizations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignResources",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignResources", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_AssignResources_Project_ProjectGuid",
                        column: x => x.ProjectGuid,
                        principalTable: "Project",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Guid", "CreatedDate", "CreatedbyUserGuid", "IsActive", "KeyValue", "Level", "Name", "ParentCode", "PermissionCode" },
                values: new object[,]
                {
                    { new Guid("4cc51c61-b990-4354-a3f8-51f24ac3b692"), new DateTime(2021, 12, 31, 22, 48, 1, 753, DateTimeKind.Local).AddTicks(8457), new Guid("00000000-0000-0000-0000-000000000000"), true, "create_timesheet", "1", "addtimeentry", "001", "00101" },
                    { new Guid("bfa71cc8-3c57-48b9-8c5a-2580b0c13ea2"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1339), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddClient", "1", "add", "002", "00215" },
                    { new Guid("f16ed57f-202d-4576-8fc1-ca8453a33c5e"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1341), new Guid("00000000-0000-0000-0000-000000000000"), true, "EditClient", "1", "edit", "002", "00216" },
                    { new Guid("49f8de3d-173f-42b1-9cbb-411ad24d803e"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1344), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveClient", "1", "remove", "002", "00217" },
                    { new Guid("a28a89cb-6f1b-4e9f-9e5c-9d5162c8e14a"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1347), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAllEmployees", "1", "getall", "002", "00218" },
                    { new Guid("7826b00c-6598-42ab-907c-0630c3b26744"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1350), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetEmployeesById", "1", "getbyid", "002", "00219" },
                    { new Guid("97b0a3bb-e9db-483d-843a-d90bfa34968e"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1353), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "0", "employeeadmin", "", "003" },
                    { new Guid("b849c1f6-96fd-4ab0-8e88-be0b789ec103"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1356), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Employee", "1", "createemployee", "003", "00301" },
                    { new Guid("0f2159d1-2d65-4d5e-a1e1-f281adc7bdbe"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1361), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Employee", "1", "viewemployee", "003", "00302" },
                    { new Guid("fdf286db-34b6-4a72-88eb-0673986c9669"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1336), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetClient", "1", "get", "002", "00214" },
                    { new Guid("f1348b3c-c49f-4dfa-af7a-f3eb7bc1cbb6"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1364), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Employee", "1", "updateemployee", "003", "00303" },
                    { new Guid("c1bcbf48-8d3e-4a57-ae40-4ca95fdd60dd"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1371), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_My_Profile", "1", "viewmyprofile", "003", "00305" },
                    { new Guid("809f734f-3311-4ba2-b2ba-b771dc41e102"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1374), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_My_Profile", "1", "updatemyprofile", "003", "00306" },
                    { new Guid("b1cfeb54-9aeb-4192-8197-3d3f02faf55b"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1377), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "0", "usermanagementadmin", "", "004" },
                    { new Guid("4d9ef056-fc64-4fe4-bc16-bd5ecdeb9b94"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1380), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Group", "1", "creategroup", "004", "00401" },
                    { new Guid("6b7861f0-26fc-4a1c-ab39-afb2e1c9e3f5"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1382), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Group", "1", "viewgroup", "004", "00402" },
                    { new Guid("3edaa88b-6c11-4134-a5f0-6bb42747f52b"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1387), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Group", "1", "updategroup", "004", "00403" },
                    { new Guid("8e18f6a1-78c1-4778-b624-8b3a657158d5"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1390), new Guid("00000000-0000-0000-0000-000000000000"), true, "Add_User", "1", "adduser", "004", "00404" },
                    { new Guid("a63bc393-5d87-4d0b-8cfc-64160af9114a"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1393), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_User", "1", "viewuser", "004", "00405" },
                    { new Guid("0ce9e1d0-975c-4eff-a768-d3b02af2012c"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1368), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_My_Profile", "1", "deleteuser", "003", "00304" },
                    { new Guid("2b1c3828-099e-4320-b3c2-2f26fd2bc98f"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1329), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveProjectStatus ", "1", "delete", "002", "00213" },
                    { new Guid("3ddf875b-e74d-4b22-af28-a3b3a1cdd23d"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1327), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetProjectStatusById", "1", "getprojectstatusbyid", "002", "00212" },
                    { new Guid("06e82096-e927-47da-9b8e-40f59b149ddb"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1324), new Guid("00000000-0000-0000-0000-000000000000"), true, "ViewProjectStatus", "1", "getall", "002", "00211" },
                    { new Guid("cc115f5c-0400-4fa0-baf2-87e6944bd2ac"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1024), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet", "1", "gettimesheet", "001", "00102" },
                    { new Guid("2f0c6e80-0bb2-4d49-b28f-8b682922dd59"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1102), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeEntries", "1", "gettimeentries", "001", "00103" },
                    { new Guid("48aac3c4-42ec-48fc-80fd-8cc911f68bb5"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1107), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_TimeEntry", "1", "updatetimeentry", "001", "00104" },
                    { new Guid("96dd4c07-dd55-4879-8957-ba3e787764fe"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1111), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_TimeEntry", "1", "deletetimeentry", "001", "00105" },
                    { new Guid("57f766e2-64e6-43c8-b7eb-400b75d19500"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1254), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetApprovalStatus", "1", "getapprovalstatus", "001", "00106" },
                    { new Guid("f0e81a90-5b7e-4ccd-b6a8-b9efece858dd"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1261), new Guid("00000000-0000-0000-0000-000000000000"), true, "Approve_timesheet", "1", "addapprovalstatus", "001", "00107" },
                    { new Guid("4702e9aa-98f1-4aa9-83d1-3daf4d0c81cd"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1279), new Guid("00000000-0000-0000-0000-000000000000"), true, "Reject_TimeSheet", "1", "rejecttimesheet", "001", "00108" },
                    { new Guid("98b0340b-bf01-4aa1-9886-d938ea82ccb8"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1282), new Guid("00000000-0000-0000-0000-000000000000"), true, "Request_ForReview", "1", "requestforreview", "001", "00109" },
                    { new Guid("bd59963e-bbb4-4380-ba20-abd914c97011"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1287), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeSheetConfiguration", "1", "gettimesheetconfiguration", "001", "00110" },
                    { new Guid("c39ed767-61ec-43cd-9188-697e27c87d88"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1290), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Resource", "1", "addassignresource", "002", "00201" },
                    { new Guid("bb8a27ac-d724-41b6-83ce-e87867bc7470"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1293), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Resources", "1", "getassignresource", "002", "00202" },
                    { new Guid("794bbe07-a319-4161-8b5b-606b5d02a3bb"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1296), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAssignedResourceById", "1", "getassignresourcebyid", "002", "00203" },
                    { new Guid("498ba28e-45dc-442b-8845-6b2e410cb213"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1300), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Resources", "1", "updateassignresource", "002", "00204" },
                    { new Guid("b014fd00-4334-409f-83a1-a686891bc8f2"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1302), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Resource", "1", "deleteassignresource", "002", "00205" },
                    { new Guid("58ca0a8b-1e85-4c00-bef5-85434644482f"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1309), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Project", "1", "get", "002", "00206" },
                    { new Guid("1a17bf32-7917-43a7-86c0-5f10e626338c"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1312), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Project", "1", "add", "002", "00207" },
                    { new Guid("bd1a997d-2c16-41ee-bcee-0c5bac342bb3"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1316), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Project", "1", "edit", "002", "00208" },
                    { new Guid("0b8495ee-adc8-4e99-83ea-cef9cdf27c23"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1318), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Project", "1", "remove", "002", "00209" },
                    { new Guid("a8bdeb4c-c6bb-4369-a97b-e9bd918b7901"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1321), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddProjectStatus", "1", "add", "002", "00210" },
                    { new Guid("4c4c4dee-8e2a-4ef8-a727-dd1a79acdd49"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1396), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_User", "1", "updateuser", "004", "00406" },
                    { new Guid("524a9685-c28e-4b1f-b19a-db2f3e8c43f3"), new DateTime(2021, 12, 31, 22, 48, 1, 762, DateTimeKind.Local).AddTicks(1399), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_User", "1", "deleteuser", "004", "00407" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_ApplicantId",
                table: "ApplicantAreaOfInterest",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_LuPositionToApplyGuid",
                table: "ApplicantAreaOfInterest",
                column: "LuPositionToApplyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_ProficiencyLevelID",
                table: "ApplicantAreaOfInterest",
                column: "ProficiencyLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_AssignResources_ProjectGuid",
                table: "AssignResources",
                column: "ProjectGuid");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddresses_ClientDetailsGuid",
                table: "BillingAddresses",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ClientDetailsGuid",
                table: "ClientContacts",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_ClientStatusGuid",
                table: "ClientDetails",
                column: "ClientStatusGuid");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_ClientDetailsGuid",
                table: "CompanyContacts",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DutyBranches_CountryId",
                table: "DutyBranches",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EducationProgrammeId",
                table: "Educations",
                column: "EducationProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations",
                column: "FieldOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactsModel_EmployeeGuid",
                table: "EmergencyContactsModel",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrganizations_BranchGuid",
                table: "EmployeeOrganizations",
                column: "BranchGuid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrganizations_EmployeeId",
                table: "EmployeeOrganizations",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_EmployeeId",
                table: "FamilyDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_RelationshipId",
                table: "FamilyDetails",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSetPermissions_GroupSetId",
                table: "GroupSetPermissions",
                column: "GroupSetId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSetPermissions_PermissionId",
                table: "GroupSetPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_LUPositionSkillSet_LUPositionToApplyId",
                table: "LUPositionSkillSet",
                column: "LUPositionToApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_LUPositionSkillSet_LUSkillSetId",
                table: "LUPositionSkillSet",
                column: "LUSkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_EmployeeGuid",
                table: "Nationalities",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingAddresses_ClientDetailsGuid",
                table: "OperatingAddresses",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAddresses_EmployeeGuid",
                table: "PersonalAddresses",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientGuid",
                table: "Project",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectStatusGuid",
                table: "Project",
                column: "ProjectStatusGuid");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPositionAssociation_luPositionToApplyGuid",
                table: "SkillPositionAssociation",
                column: "luPositionToApplyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPositionAssociation_skillSetGuid",
                table: "SkillPositionAssociation",
                column: "skillSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_TimesheetGuid",
                table: "TimeEntry",
                column: "TimesheetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantAreaOfInterest");

            migrationBuilder.DropTable(
                name: "AssignResources");

            migrationBuilder.DropTable(
                name: "BillingAddresses");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "CompanyContacts");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "DeviceDetails");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmergencyAddresses");

            migrationBuilder.DropTable(
                name: "EmergencyContactsModel");

            migrationBuilder.DropTable(
                name: "EmployeeOrganizations");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "GroupSetPermissions");

            migrationBuilder.DropTable(
                name: "JobRequirment");

            migrationBuilder.DropTable(
                name: "LUPositionSkillSet");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "OperatingAddresses");

            migrationBuilder.DropTable(
                name: "PersonalAddresses");

            migrationBuilder.DropTable(
                name: "SkillPositionAssociation");

            migrationBuilder.DropTable(
                name: "TimeEntry");

            migrationBuilder.DropTable(
                name: "TimesheetAprovals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProficiencyLevel");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "EducationProgrammes");

            migrationBuilder.DropTable(
                name: "FieldOfStudie");

            migrationBuilder.DropTable(
                name: "DutyBranches");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "PositionToApply");

            migrationBuilder.DropTable(
                name: "SkillSet");

            migrationBuilder.DropTable(
                name: "TimeSheet");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ClientDetails");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ClientStatus");
        }
    }
}
