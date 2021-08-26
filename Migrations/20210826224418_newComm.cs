using Microsoft.EntityFrameworkCore.Migrations;

namespace Arcade.Migrations
{
    public partial class newComm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Association",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Association_CommentId",
                table: "Association",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Association_Comments_CommentId",
                table: "Association",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "CommentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Association_Comments_CommentId",
                table: "Association");

            migrationBuilder.DropIndex(
                name: "IX_Association_CommentId",
                table: "Association");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Association");
        }
    }
}
