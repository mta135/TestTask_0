using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask_0.Migrations
{
    public partial class Create_null_Column_CategoryId_Review_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                schema: "dbo",
                table: "Reviews",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "dbo",
                table: "Reviews");
        }
    }
}
