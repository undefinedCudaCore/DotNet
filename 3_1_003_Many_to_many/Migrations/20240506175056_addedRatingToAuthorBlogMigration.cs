using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3_1_003_Many_to_many.Migrations
{
    /// <inheritdoc />
    public partial class addedRatingToAuthorBlogMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "AuthorBlogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "AuthorBlogs");
        }
    }
}
