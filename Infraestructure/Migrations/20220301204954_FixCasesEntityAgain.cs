using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Continental.API.Infrastructure.Migrations
{
    public partial class FixCasesEntityAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Cases_Users_UserId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cases",
                newName: "UserWhoModifiedId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_UserId",
                table: "Cases",
                newName: "IX_Cases_UserWhoModifiedId");

            migrationBuilder.AlterColumn<int>(
                name: "TypificationId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubtypeId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OriginId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CaseStatusId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CaseOwnerId",
                table: "Cases",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Cases_UserWhoCreatedId",
                table: "Cases",
                column: "UserWhoCreatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseOrigin_OriginId",
                table: "Cases",
                column: "OriginId",
                principalTable: "CaseOrigin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId",
                principalTable: "CaseStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseSubtype_SubtypeId",
                table: "Cases",
                column: "SubtypeId",
                principalTable: "CaseSubtype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseType_TypeId",
                table: "Cases",
                column: "TypeId",
                principalTable: "CaseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseTypification_TypificationId",
                table: "Cases",
                column: "TypificationId",
                principalTable: "CaseTypification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Clerks_CaseOwnerId",
                table: "Cases",
                column: "CaseOwnerId",
                principalTable: "Clerks",
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
                name: "FK_Cases_Users_UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Users_UserWhoModifiedId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "UserWhoCreatedId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "UserWhoModifiedId",
                table: "Cases",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_UserWhoModifiedId",
                table: "Cases",
                newName: "IX_Cases_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "TypificationId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SubtypeId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OriginId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CaseStatusId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CaseOwnerId",
                table: "Cases",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseOrigin_OriginId",
                table: "Cases",
                column: "OriginId",
                principalTable: "CaseOrigin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId",
                principalTable: "CaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseSubtype_SubtypeId",
                table: "Cases",
                column: "SubtypeId",
                principalTable: "CaseSubtype",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseType_TypeId",
                table: "Cases",
                column: "TypeId",
                principalTable: "CaseType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseTypification_TypificationId",
                table: "Cases",
                column: "TypificationId",
                principalTable: "CaseTypification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Clerks_CaseOwnerId",
                table: "Cases",
                column: "CaseOwnerId",
                principalTable: "Clerks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Users_UserId",
                table: "Cases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
