using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phoenix.Migrations
{
    public partial class NewNameForfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UsefulUrlForPathOfExiles_UsefulUrlForPathOfExileId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "UsefulUrlForPathOfExiles");

            migrationBuilder.RenameColumn(
                name: "UsefulUrlForPathOfExileId",
                table: "Comments",
                newName: "UsefulUrlId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UsefulUrlForPathOfExileId",
                table: "Comments",
                newName: "IX_Comments_UsefulUrlId");

            migrationBuilder.CreateTable(
                name: "UsefulUrl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsefulUrl", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UsefulUrl_UsefulUrlId",
                table: "Comments",
                column: "UsefulUrlId",
                principalTable: "UsefulUrl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UsefulUrl_UsefulUrlId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "UsefulUrl");

            migrationBuilder.RenameColumn(
                name: "UsefulUrlId",
                table: "Comments",
                newName: "UsefulUrlForPathOfExileId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UsefulUrlId",
                table: "Comments",
                newName: "IX_Comments_UsefulUrlForPathOfExileId");

            migrationBuilder.CreateTable(
                name: "UsefulUrlForPathOfExiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentsId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsefulUrlForPathOfExiles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UsefulUrlForPathOfExiles_UsefulUrlForPathOfExileId",
                table: "Comments",
                column: "UsefulUrlForPathOfExileId",
                principalTable: "UsefulUrlForPathOfExiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
