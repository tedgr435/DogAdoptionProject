using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoptionProject.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_userId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Dog_currentDogIdId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_currentDogIdId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Application_userId",
                table: "Application");

            migrationBuilder.RenameColumn(
                name: "currentDogIdId",
                table: "User",
                newName: "currentDogId");

            migrationBuilder.AddColumn<int>(
                name: "currentAppId",
                table: "User",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "currentAppId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "currentDogId",
                table: "User",
                newName: "currentDogIdId");

            migrationBuilder.CreateIndex(
                name: "IX_User_currentDogIdId",
                table: "User",
                column: "currentDogIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_userId",
                table: "Application",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_User_userId",
                table: "Application",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dog_currentDogIdId",
                table: "User",
                column: "currentDogIdId",
                principalTable: "Dog",
                principalColumn: "Id");
        }
    }
}
