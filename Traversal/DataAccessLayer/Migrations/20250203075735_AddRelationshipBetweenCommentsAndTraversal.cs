using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipBetweenCommentsAndTraversal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TraversalUserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TraversalUserId",
                table: "Comments",
                column: "TraversalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_TraversalUserId",
                table: "Comments",
                column: "TraversalUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_TraversalUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TraversalUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TraversalUserId",
                table: "Comments");
        }
    }
}
