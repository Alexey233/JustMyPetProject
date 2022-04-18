using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phoenix.Migrations
{
    public partial class AddNewModelComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usefulUrlForPathOfExiles",
                table: "usefulUrlForPathOfExiles");

            migrationBuilder.RenameTable(
                name: "usefulUrlForPathOfExiles",
                newName: "UsefulUrlForPathOfExiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsefulUrlForPathOfExiles",
                table: "UsefulUrlForPathOfExiles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsefulUrlForPathOfExiles",
                table: "UsefulUrlForPathOfExiles");

            migrationBuilder.RenameTable(
                name: "UsefulUrlForPathOfExiles",
                newName: "usefulUrlForPathOfExiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usefulUrlForPathOfExiles",
                table: "usefulUrlForPathOfExiles",
                column: "Id");
        }
    }
}
