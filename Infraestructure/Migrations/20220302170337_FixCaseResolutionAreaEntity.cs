using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class FixCaseResolutionAreaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_ResolutionArea_ResolutionAreaId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_ResolutionAreaId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ResolutionAreaId",
                table: "Cases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResolutionAreaId",
                table: "Cases",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ResolutionAreaId",
                table: "Cases",
                column: "ResolutionAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_ResolutionArea_ResolutionAreaId",
                table: "Cases",
                column: "ResolutionAreaId",
                principalTable: "ResolutionArea",
                principalColumn: "Id");
        }
    }
}
