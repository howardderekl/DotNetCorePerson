using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumansOfNewYork.Migrations
{
    public partial class AdjustPictureToUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Original",
                table: "Pictures");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Pictures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Pictures");

            migrationBuilder.AddColumn<byte[]>(
                name: "Original",
                table: "Pictures",
                nullable: true);
        }
    }
}
