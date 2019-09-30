using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class typemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_Type_TypeId",
                table: "Move");

            migrationBuilder.DropIndex(
                name: "IX_Move_TypeId",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Move");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Move",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Move_TypeId",
                table: "Move",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Type_TypeId",
                table: "Move",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
