using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Users_IdForProfile",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "IdForProfile",
                table: "Skills",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_IdForProfile",
                table: "Skills",
                newName: "IX_Skills_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Users_UserId",
                table: "Skills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Users_UserId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Skills",
                newName: "IdForProfile");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_UserId",
                table: "Skills",
                newName: "IX_Skills_IdForProfile");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Users_IdForProfile",
                table: "Skills",
                column: "IdForProfile",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
