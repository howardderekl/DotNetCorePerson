using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumansOfNewYork.Migrations
{
    public partial class FixPictureRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Persons_PersonId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_PersonId",
                table: "Pictures");

            migrationBuilder.AddColumn<int>(
                name: "PictureId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PictureId1",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PictureId1",
                table: "Persons",
                column: "PictureId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Pictures_PictureId1",
                table: "Persons",
                column: "PictureId1",
                principalTable: "Pictures",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Pictures_PictureId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PictureId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PictureId1",
                table: "Persons");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_PersonId",
                table: "Pictures",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Persons_PersonId",
                table: "Pictures",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
