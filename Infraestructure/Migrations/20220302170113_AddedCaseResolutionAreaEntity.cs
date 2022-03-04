using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class AddedCaseResolutionAreaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseResolutionArea_Cases_CasesId",
                table: "CaseResolutionArea");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseResolutionArea_ResolutionArea_ResolutionAreasId",
                table: "CaseResolutionArea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseResolutionArea",
                table: "CaseResolutionArea");

            migrationBuilder.RenameColumn(
                name: "ResolutionAreasId",
                table: "CaseResolutionArea",
                newName: "ResolutionAreaId");

            migrationBuilder.RenameColumn(
                name: "CasesId",
                table: "CaseResolutionArea",
                newName: "CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseResolutionArea_ResolutionAreasId",
                table: "CaseResolutionArea",
                newName: "IX_CaseResolutionArea_ResolutionAreaId");

            migrationBuilder.AddColumn<int>(
                name: "ResolutionAreaId",
                table: "Cases",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CaseResolutionArea",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseResolutionArea",
                table: "CaseResolutionArea",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ResolutionAreaId",
                table: "Cases",
                column: "ResolutionAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseResolutionArea_CaseId",
                table: "CaseResolutionArea",
                column: "CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseResolutionArea_Cases_CaseId",
                table: "CaseResolutionArea",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CaseResolutionArea_ResolutionArea_ResolutionAreaId",
                table: "CaseResolutionArea",
                column: "ResolutionAreaId",
                principalTable: "ResolutionArea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_ResolutionArea_ResolutionAreaId",
                table: "Cases",
                column: "ResolutionAreaId",
                principalTable: "ResolutionArea",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseResolutionArea_Cases_CaseId",
                table: "CaseResolutionArea");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseResolutionArea_ResolutionArea_ResolutionAreaId",
                table: "CaseResolutionArea");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_ResolutionArea_ResolutionAreaId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_ResolutionAreaId",
                table: "Cases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseResolutionArea",
                table: "CaseResolutionArea");

            migrationBuilder.DropIndex(
                name: "IX_CaseResolutionArea_CaseId",
                table: "CaseResolutionArea");

            migrationBuilder.DropColumn(
                name: "ResolutionAreaId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CaseResolutionArea");

            migrationBuilder.RenameColumn(
                name: "ResolutionAreaId",
                table: "CaseResolutionArea",
                newName: "ResolutionAreasId");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "CaseResolutionArea",
                newName: "CasesId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseResolutionArea_ResolutionAreaId",
                table: "CaseResolutionArea",
                newName: "IX_CaseResolutionArea_ResolutionAreasId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseResolutionArea",
                table: "CaseResolutionArea",
                columns: new[] { "CasesId", "ResolutionAreasId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CaseResolutionArea_Cases_CasesId",
                table: "CaseResolutionArea",
                column: "CasesId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CaseResolutionArea_ResolutionArea_ResolutionAreasId",
                table: "CaseResolutionArea",
                column: "ResolutionAreasId",
                principalTable: "ResolutionArea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
