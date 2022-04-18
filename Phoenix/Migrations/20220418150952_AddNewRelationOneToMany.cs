using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phoenix.Migrations
{
    public partial class AddNewRelationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentsId",
                table: "UsefulUrlForPathOfExiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsefulUrlForPathOfExileId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UsefulUrlForPathOfExileId",
                table: "Comments",
                column: "UsefulUrlForPathOfExileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UsefulUrlForPathOfExiles_UsefulUrlForPathOfExileId",
                table: "Comments",
                column: "UsefulUrlForPathOfExileId",
                principalTable: "UsefulUrlForPathOfExiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UsefulUrlForPathOfExiles_UsefulUrlForPathOfExileId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UsefulUrlForPathOfExileId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentsId",
                table: "UsefulUrlForPathOfExiles");

            migrationBuilder.DropColumn(
                name: "UsefulUrlForPathOfExileId",
                table: "Comments");
        }
    }
}
