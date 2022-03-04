using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class FixCasesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoCreatedId1",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId1",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_BranchManagerUserId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_SupervisorUserId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_TeamLeaderUserId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserWhoCreatedId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserWhoModifiedId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_ResolutionArea_Cases_CaseId",
                table: "ResolutionArea");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cases_CaseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CaseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ResolutionArea_CaseId",
                table: "ResolutionArea");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_BranchManagerUserId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_SupervisorUserId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_TeamLeaderUserId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserWhoCreatedId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserWhoModifiedId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Cases_UserWhoCreatedId1",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "ResolutionArea");

            migrationBuilder.DropColumn(
                name: "BranchManagerUserId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "SupervisorUserId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "TeamLeaderUserId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UserWhoCreatedId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UserWhoModifiedId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UserWhoCreatedId1",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UserWhoModifiedId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "UserWhoModifiedId1",
                table: "Cases",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_UserWhoModifiedId1",
                table: "Cases",
                newName: "IX_Cases_UserId");

            migrationBuilder.CreateTable(
                name: "CaseResolutionArea",
                columns: table => new
                {
                    CasesId = table.Column<int>(type: "integer", nullable: false),
                    ResolutionAreasId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseResolutionArea", x => new { x.CasesId, x.ResolutionAreasId });
                    table.ForeignKey(
                        name: "FK_CaseResolutionArea_Cases_CasesId",
                        column: x => x.CasesId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseResolutionArea_ResolutionArea_ResolutionAreasId",
                        column: x => x.ResolutionAreasId,
                        principalTable: "ResolutionArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resolver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CaseId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resolver_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resolver_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchManagerUserId",
                table: "Contacts",
                column: "BranchManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SupervisorUserId",
                table: "Contacts",
                column: "SupervisorUserId");

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
                name: "IX_CaseResolutionArea_ResolutionAreasId",
                table: "CaseResolutionArea",
                column: "ResolutionAreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolver_CaseId",
                table: "Resolver",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolver_UserId",
                table: "Resolver",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserId",
                table: "Cases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

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
                name: "FK_Cases_Users_UserId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_BranchManagerUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_SupervisorUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_TeamLeaderUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserWhoCreatedId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserWhoModifiedId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "CaseResolutionArea");

            migrationBuilder.DropTable(
                name: "Resolver");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_BranchManagerUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_SupervisorUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_TeamLeaderUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserWhoCreatedId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserWhoModifiedId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cases",
                newName: "UserWhoModifiedId1");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_UserId",
                table: "Cases",
                newName: "IX_Cases_UserWhoModifiedId1");

            migrationBuilder.AddColumn<int>(
                name: "CaseId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseId",
                table: "ResolutionArea",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchManagerUserId1",
                table: "Contacts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorUserId1",
                table: "Contacts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamLeaderUserId1",
                table: "Contacts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoCreatedId1",
                table: "Contacts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoModifiedId1",
                table: "Contacts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cases",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cases",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoCreatedId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoCreatedId1",
                table: "Cases",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoModifiedId",
                table: "Cases",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CaseId",
                table: "Users",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResolutionArea_CaseId",
                table: "ResolutionArea",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchManagerUserId1",
                table: "Contacts",
                column: "BranchManagerUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SupervisorUserId1",
                table: "Contacts",
                column: "SupervisorUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeamLeaderUserId1",
                table: "Contacts",
                column: "TeamLeaderUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserWhoCreatedId1",
                table: "Contacts",
                column: "UserWhoCreatedId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserWhoModifiedId1",
                table: "Contacts",
                column: "UserWhoModifiedId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoCreatedId1",
                table: "Cases",
                column: "UserWhoCreatedId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserWhoCreatedId1",
                table: "Cases",
                column: "UserWhoCreatedId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId1",
                table: "Cases",
                column: "UserWhoModifiedId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_BranchManagerUserId1",
                table: "Contacts",
                column: "BranchManagerUserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_SupervisorUserId1",
                table: "Contacts",
                column: "SupervisorUserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_TeamLeaderUserId1",
                table: "Contacts",
                column: "TeamLeaderUserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserWhoCreatedId1",
                table: "Contacts",
                column: "UserWhoCreatedId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserWhoModifiedId1",
                table: "Contacts",
                column: "UserWhoModifiedId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResolutionArea_Cases_CaseId",
                table: "ResolutionArea",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cases_CaseId",
                table: "Users",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id");
        }
    }
}
