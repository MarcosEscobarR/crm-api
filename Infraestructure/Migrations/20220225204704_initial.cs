using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseOrigin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseOrigin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseSubtype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseSubtype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseTypification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseTypification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CivilStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivilStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WalletTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FinansysTicketNumber = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    PromoterId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    SubtypeId = table.Column<int>(type: "integer", nullable: true),
                    TypificationId = table.Column<int>(type: "integer", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    OriginId = table.Column<int>(type: "integer", nullable: true),
                    CaseStatusId = table.Column<int>(type: "integer", nullable: true),
                    IdServidesk = table.Column<string>(type: "text", nullable: true),
                    CaseOwnerId = table.Column<int>(type: "integer", nullable: true),
                    BusinessOfficer = table.Column<string>(type: "text", nullable: true),
                    Solution = table.Column<string>(type: "text", nullable: true),
                    ClientComment = table.Column<string>(type: "text", nullable: true),
                    Qualification = table.Column<string>(type: "text", nullable: true),
                    RequestExtension = table.Column<bool>(type: "boolean", nullable: false),
                    AttachmentFile = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserWhoCreatedId = table.Column<int>(type: "integer", nullable: false),
                    UserWhoModifiedId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_CaseOrigin_OriginId",
                        column: x => x.OriginId,
                        principalTable: "CaseOrigin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CaseStatus_CaseStatusId",
                        column: x => x.CaseStatusId,
                        principalTable: "CaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CaseSubtype_SubtypeId",
                        column: x => x.SubtypeId,
                        principalTable: "CaseSubtype",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CaseType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CaseTypification_TypificationId",
                        column: x => x.TypificationId,
                        principalTable: "CaseTypification",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResolutionArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CasesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResolutionArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResolutionArea_Cases_CasesId",
                        column: x => x.CasesId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clerks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clerks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Ruc = table.Column<string>(type: "text", nullable: true),
                    Foundation = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    ParentCompanyId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EmployersQuantity = table.Column<int>(type: "integer", nullable: false),
                    EconomicActivity = table.Column<string>(type: "text", nullable: true),
                    BillingRange = table.Column<int>(type: "integer", nullable: false),
                    WalletTypeId = table.Column<int>(type: "integer", nullable: false),
                    PaymentEntity = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Zone = table.Column<string>(type: "text", nullable: true),
                    Reference = table.Column<string>(type: "text", nullable: true),
                    HomeNumber = table.Column<int>(type: "integer", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    BillingCountry = table.Column<string>(type: "text", nullable: true),
                    BillingState = table.Column<string>(type: "text", nullable: true),
                    BillingStreet = table.Column<string>(type: "text", nullable: true),
                    IsClient = table.Column<int>(type: "integer", nullable: false),
                    ClientCode = table.Column<string>(type: "text", nullable: true),
                    BancaId = table.Column<int>(type: "integer", nullable: true),
                    ClientState = table.Column<int>(type: "integer", nullable: false),
                    OwnerCompanyId = table.Column<int>(type: "integer", nullable: false),
                    BranchId = table.Column<int>(type: "integer", nullable: true),
                    BracnId = table.Column<int>(type: "integer", nullable: false),
                    OfficialId = table.Column<int>(type: "integer", nullable: false),
                    ClientFont = table.Column<int>(type: "integer", nullable: false),
                    LeadId = table.Column<int>(type: "integer", nullable: false),
                    SupervisorUserId = table.Column<int>(type: "integer", nullable: false),
                    TeamLeaderUserId = table.Column<int>(type: "integer", nullable: false),
                    BranchManagerUserId = table.Column<int>(type: "integer", nullable: false),
                    SupervisorClerkId = table.Column<int>(type: "integer", nullable: false),
                    TeamLeaderClerkId = table.Column<int>(type: "integer", nullable: false),
                    BranchManagerClerkId = table.Column<int>(type: "integer", nullable: false),
                    LeadsSource = table.Column<int>(type: "integer", nullable: false),
                    ContactOwnerId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserWhoCreatedId = table.Column<int>(type: "integer", nullable: false),
                    UserWhoModifiedId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Bancas_BancaId",
                        column: x => x.BancaId,
                        principalTable: "Bancas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_Clerks_BranchManagerClerkId",
                        column: x => x.BranchManagerClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Clerks_ContactOwnerId",
                        column: x => x.ContactOwnerId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Clerks_OwnerCompanyId",
                        column: x => x.OwnerCompanyId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Clerks_SupervisorClerkId",
                        column: x => x.SupervisorClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Clerks_TeamLeaderClerkId",
                        column: x => x.TeamLeaderClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Companies_ParentCompanyId",
                        column: x => x.ParentCompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_WalletTypes_WalletTypeId",
                        column: x => x.WalletTypeId,
                        principalTable: "WalletTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomicActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomicActivity_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lead_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperatingEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingEntity_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyContact",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "integer", nullable: false),
                    ContactsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContact", x => new { x.CompaniesId, x.ContactsId });
                    table.ForeignKey(
                        name: "FK_CompanyContact_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    DocumentNumber = table.Column<string>(type: "text", nullable: true),
                    GenderId = table.Column<int>(type: "integer", nullable: true),
                    GenderTypeId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    CivilStatusId = table.Column<int>(type: "integer", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    WalletTypeId = table.Column<int>(type: "integer", nullable: false),
                    ClientCode = table.Column<string>(type: "text", nullable: true),
                    ContactTypeId = table.Column<int>(type: "integer", nullable: false),
                    IsClient = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    SecondaryEmail = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    Landline = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    HomeNumber = table.Column<string>(type: "text", nullable: true),
                    Reference = table.Column<string>(type: "text", nullable: true),
                    Department = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    MailingStreet = table.Column<string>(type: "text", nullable: true),
                    MailingCountry = table.Column<string>(type: "text", nullable: true),
                    MailingState = table.Column<string>(type: "text", nullable: true),
                    MailingCity = table.Column<string>(type: "text", nullable: true),
                    WorkPlace = table.Column<string>(type: "text", nullable: true),
                    CurrentSalary = table.Column<string>(type: "text", nullable: true),
                    WorkPhone = table.Column<string>(type: "text", nullable: true),
                    AssistantName = table.Column<string>(type: "text", nullable: true),
                    AssistantEmail = table.Column<string>(type: "text", nullable: true),
                    AssistantPhone = table.Column<string>(type: "text", nullable: true),
                    EconomicActivity = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BancaId = table.Column<int>(type: "integer", nullable: false),
                    BranchId = table.Column<int>(type: "integer", nullable: false),
                    SupervisorClerkId = table.Column<int>(type: "integer", nullable: false),
                    TeamLeaderClerkId = table.Column<int>(type: "integer", nullable: false),
                    BranchManagerClerkId = table.Column<int>(type: "integer", nullable: false),
                    OfficialId = table.Column<int>(type: "integer", nullable: false),
                    SupervisorUserId = table.Column<int>(type: "integer", nullable: false),
                    TeamLeaderUserId = table.Column<int>(type: "integer", nullable: false),
                    BranchManagerUserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserWhoCreatedId = table.Column<int>(type: "integer", nullable: false),
                    UserWhoModifiedId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Bancas_BancaId",
                        column: x => x.BancaId,
                        principalTable: "Bancas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_CivilStatus_CivilStatusId",
                        column: x => x.CivilStatusId,
                        principalTable: "CivilStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Clerks_BranchManagerClerkId",
                        column: x => x.BranchManagerClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Clerks_OfficialId",
                        column: x => x.OfficialId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Clerks_SupervisorClerkId",
                        column: x => x.SupervisorClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Clerks_TeamLeaderClerkId",
                        column: x => x.TeamLeaderClerkId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactTypes_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contacts_WalletTypes_WalletTypeId",
                        column: x => x.WalletTypeId,
                        principalTable: "WalletTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdentityId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CasesId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cases_CasesId",
                        column: x => x.CasesId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseOwnerId",
                table: "Cases",
                column: "CaseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CompanyId",
                table: "Cases",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ContactId",
                table: "Cases",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_OriginId",
                table: "Cases",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PromoterId",
                table: "Cases",
                column: "PromoterId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_SubtypeId",
                table: "Cases",
                column: "SubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_TypeId",
                table: "Cases",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_TypificationId",
                table: "Cases",
                column: "TypificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoCreatedId",
                table: "Cases",
                column: "UserWhoCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoModifiedId",
                table: "Cases",
                column: "UserWhoModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Clerks_UserId",
                table: "Clerks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BancaId",
                table: "Companies",
                column: "BancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BranchId",
                table: "Companies",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BranchManagerClerkId",
                table: "Companies",
                column: "BranchManagerClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BranchManagerUserId",
                table: "Companies",
                column: "BranchManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ContactOwnerId",
                table: "Companies",
                column: "ContactOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LeadId",
                table: "Companies",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OfficialId",
                table: "Companies",
                column: "OfficialId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OwnerCompanyId",
                table: "Companies",
                column: "OwnerCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ParentCompanyId",
                table: "Companies",
                column: "ParentCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SupervisorClerkId",
                table: "Companies",
                column: "SupervisorClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SupervisorUserId",
                table: "Companies",
                column: "SupervisorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TeamLeaderClerkId",
                table: "Companies",
                column: "TeamLeaderClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TeamLeaderUserId",
                table: "Companies",
                column: "TeamLeaderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserWhoCreatedId",
                table: "Companies",
                column: "UserWhoCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserWhoModifiedId",
                table: "Companies",
                column: "UserWhoModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_WalletTypeId",
                table: "Companies",
                column: "WalletTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContact_ContactsId",
                table: "CompanyContact",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BancaId",
                table: "Contacts",
                column: "BancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchId",
                table: "Contacts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchManagerClerkId",
                table: "Contacts",
                column: "BranchManagerClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchManagerUserId",
                table: "Contacts",
                column: "BranchManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CivilStatusId",
                table: "Contacts",
                column: "CivilStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactTypeId",
                table: "Contacts",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DocumentTypeId",
                table: "Contacts",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_GenderId",
                table: "Contacts",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OfficialId",
                table: "Contacts",
                column: "OfficialId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SupervisorClerkId",
                table: "Contacts",
                column: "SupervisorClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SupervisorUserId",
                table: "Contacts",
                column: "SupervisorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeamLeaderClerkId",
                table: "Contacts",
                column: "TeamLeaderClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeamLeaderUserId",
                table: "Contacts",
                column: "TeamLeaderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserWhoCreatedId",
                table: "Contacts",
                column: "UserWhoCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserWhoModifiedId",
                table: "Contacts",
                column: "UserWhoModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_WalletTypeId",
                table: "Contacts",
                column: "WalletTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicActivity_CompanyId",
                table: "EconomicActivity",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CompanyId",
                table: "Lead",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingEntity_CompanyId",
                table: "OperatingEntity",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResolutionArea_CasesId",
                table: "ResolutionArea",
                column: "CasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CasesId",
                table: "Users",
                column: "CasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContactId",
                table: "Users",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Clerks_CaseOwnerId",
                table: "Cases",
                column: "CaseOwnerId",
                principalTable: "Clerks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Companies_CompanyId",
                table: "Cases",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Contacts_ContactId",
                table: "Cases",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Contacts_PromoterId",
                table: "Cases",
                column: "PromoterId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserWhoCreatedId",
                table: "Cases",
                column: "UserWhoCreatedId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId",
                table: "Cases",
                column: "UserWhoModifiedId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clerks_Users_UserId",
                table: "Clerks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Lead_LeadId",
                table: "Companies",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_BranchManagerUserId",
                table: "Companies",
                column: "BranchManagerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_OfficialId",
                table: "Companies",
                column: "OfficialId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_SupervisorUserId",
                table: "Companies",
                column: "SupervisorUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_TeamLeaderUserId",
                table: "Companies",
                column: "TeamLeaderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_UserWhoCreatedId",
                table: "Companies",
                column: "UserWhoCreatedId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_UserWhoModifiedId",
                table: "Companies",
                column: "UserWhoModifiedId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyContact_Contacts_ContactsId",
                table: "CompanyContact",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_BranchManagerUserId",
                table: "Contacts",
                column: "BranchManagerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_SupervisorUserId",
                table: "Contacts",
                column: "SupervisorUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_TeamLeaderUserId",
                table: "Contacts",
                column: "TeamLeaderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserWhoCreatedId",
                table: "Contacts",
                column: "UserWhoCreatedId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserWhoModifiedId",
                table: "Contacts",
                column: "UserWhoModifiedId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseOrigin_OriginId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatusId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseSubtype_SubtypeId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseType_TypeId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseTypification_TypificationId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Clerks_CaseOwnerId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clerks_BranchManagerClerkId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clerks_ContactOwnerId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clerks_OwnerCompanyId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clerks_SupervisorClerkId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clerks_TeamLeaderClerkId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Clerks_BranchManagerClerkId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Clerks_OfficialId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Clerks_SupervisorClerkId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Clerks_TeamLeaderClerkId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Companies_CompanyId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Lead_Companies_CompanyId",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Contacts_ContactId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Contacts_PromoterId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Contacts_ContactId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId",
                table: "Cases");

            migrationBuilder.DropTable(
                name: "CompanyContact");

            migrationBuilder.DropTable(
                name: "EconomicActivity");

            migrationBuilder.DropTable(
                name: "OperatingEntity");

            migrationBuilder.DropTable(
                name: "ResolutionArea");

            migrationBuilder.DropTable(
                name: "CaseOrigin");

            migrationBuilder.DropTable(
                name: "CaseStatus");

            migrationBuilder.DropTable(
                name: "CaseSubtype");

            migrationBuilder.DropTable(
                name: "CaseType");

            migrationBuilder.DropTable(
                name: "CaseTypification");

            migrationBuilder.DropTable(
                name: "Clerks");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Bancas");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "CivilStatus");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "WalletTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cases");
        }
    }
}
