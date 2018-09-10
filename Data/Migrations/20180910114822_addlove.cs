using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCity.Data.Migrations
{
    public partial class addlove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoveCount",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoveCount",
                table: "Posts");
        }
    }
}
