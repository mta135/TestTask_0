using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask_0.Migrations
{
    public partial class drop_Column_CategoryID_from_Review_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "dbo",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                schema: "dbo",
                table: "Reviews",
                type: "int",
                nullable: true);
        }
    }
}
