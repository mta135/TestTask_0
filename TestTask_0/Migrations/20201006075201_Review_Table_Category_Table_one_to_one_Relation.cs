using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask_0.Migrations
{
    public partial class Review_Table_Category_Table_one_to_one_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                schema: "dbo",
                table: "Reviews",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Categories_CategoryId",
                schema: "dbo",
                table: "Reviews",
                column: "CategoryId",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Categories_CategoryId",
                schema: "dbo",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CategoryId",
                schema: "dbo",
                table: "Reviews");
        }
    }
}
