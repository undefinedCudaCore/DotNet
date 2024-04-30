using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_EF_Intro.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPageWithBookNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishTime",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PublishTime",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Pages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");
        }
    }
}
