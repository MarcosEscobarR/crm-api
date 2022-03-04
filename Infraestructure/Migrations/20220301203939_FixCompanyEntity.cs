using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class FixCompanyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Branch_BranchId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Companies_ParentCompanyId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Lead_LeadId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_LeadId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ParentCompanyId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BracnId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LeadId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ParentCompanyId",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Branch_BranchId",
                table: "Companies",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Branch_BranchId",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Companies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "BracnId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeadId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentCompanyId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LeadId",
                table: "Companies",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ParentCompanyId",
                table: "Companies",
                column: "ParentCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Branch_BranchId",
                table: "Companies",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Companies_ParentCompanyId",
                table: "Companies",
                column: "ParentCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Lead_LeadId",
                table: "Companies",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
