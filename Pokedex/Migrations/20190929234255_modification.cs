using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Move",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Move");

            migrationBuilder.AddColumn<int>(
                name: "MoveId",
                table: "Move",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Move",
                table: "Move",
                column: "MoveId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "MoveId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Move",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "MoveId",
                table: "Move");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Move",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Move",
                table: "Move",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
