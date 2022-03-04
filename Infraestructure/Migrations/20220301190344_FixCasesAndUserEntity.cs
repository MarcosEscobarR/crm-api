using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class FixCasesAndUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_ResolutionArea_Cases_CasesId",
                table: "ResolutionArea");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cases_CasesId",
                table: "Users");

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

            migrationBuilder.DropIndex(
                name: "IX_Cases_UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_UserWhoModifiedId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "CasesId",
                table: "Users",
                newName: "CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CasesId",
                table: "Users",
                newName: "IX_Users_CaseId");

            migrationBuilder.RenameColumn(
                name: "CasesId",
                table: "ResolutionArea",
                newName: "CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_ResolutionArea_CasesId",
                table: "ResolutionArea",
                newName: "IX_ResolutionArea_CaseId");

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

            migrationBuilder.AddColumn<int>(
                name: "UserWhoCreatedId1",
                table: "Cases",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWhoModifiedId1",
                table: "Cases",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoModifiedId1",
                table: "Cases",
                column: "UserWhoModifiedId1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Cases_UserWhoModifiedId1",
                table: "Cases");

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
                name: "UserWhoCreatedId1",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UserWhoModifiedId1",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "Users",
                newName: "CasesId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CaseId",
                table: "Users",
                newName: "IX_Users_CasesId");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "ResolutionArea",
                newName: "CasesId");

            migrationBuilder.RenameIndex(
                name: "IX_ResolutionArea_CaseId",
                table: "ResolutionArea",
                newName: "IX_ResolutionArea_CasesId");

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
                name: "IX_Cases_UserWhoCreatedId",
                table: "Cases",
                column: "UserWhoCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoModifiedId",
                table: "Cases",
                column: "UserWhoModifiedId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ResolutionArea_Cases_CasesId",
                table: "ResolutionArea",
                column: "CasesId",
                principalTable: "Cases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cases_CasesId",
                table: "Users",
                column: "CasesId",
                principalTable: "Cases",
                principalColumn: "Id");
        }
    }
}
