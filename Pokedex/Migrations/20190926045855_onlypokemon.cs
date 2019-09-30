using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class onlypokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Types_TypeId",
                table: "Moves");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonAbilities_Abilities_AbilityId",
                table: "PokemonAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonAbilities_Pokemons_PokemonId",
                table: "PokemonAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMoves_Moves_MoveId",
                table: "PokemonMoves");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMoves_Pokemons_PokemonId",
                table: "PokemonMoves");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTypes_Pokemons_PokemonId",
                table: "PokemonTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTypes_Types_TypeId",
                table: "PokemonTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonTypes",
                table: "PokemonTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonMoves",
                table: "PokemonMoves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonAbilities",
                table: "PokemonAbilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moves",
                table: "Moves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "Type");

            migrationBuilder.RenameTable(
                name: "PokemonTypes",
                newName: "PokemonType");

            migrationBuilder.RenameTable(
                name: "PokemonMoves",
                newName: "PokemonMove");

            migrationBuilder.RenameTable(
                name: "PokemonAbilities",
                newName: "PokemonAbility");

            migrationBuilder.RenameTable(
                name: "Moves",
                newName: "Move");

            migrationBuilder.RenameTable(
                name: "Abilities",
                newName: "Ability");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonTypes_TypeId",
                table: "PokemonType",
                newName: "IX_PokemonType_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonMoves_MoveId",
                table: "PokemonMove",
                newName: "IX_PokemonMove_MoveId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonAbilities_AbilityId",
                table: "PokemonAbility",
                newName: "IX_PokemonAbility_AbilityId");

            migrationBuilder.RenameIndex(
                name: "IX_Moves_TypeId",
                table: "Move",
                newName: "IX_Move_TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Type",
                table: "Type",
                column: "TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonType",
                table: "PokemonType",
                columns: new[] { "PokemonId", "TypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonMove",
                table: "PokemonMove",
                columns: new[] { "PokemonId", "MoveId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonAbility",
                table: "PokemonAbility",
                columns: new[] { "PokemonId", "AbilityId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Move",
                table: "Move",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ability",
                table: "Ability",
                column: "AbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Type_TypeId",
                table: "Move",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonAbility_Ability_AbilityId",
                table: "PokemonAbility",
                column: "AbilityId",
                principalTable: "Ability",
                principalColumn: "AbilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonAbility_Pokemons_PokemonId",
                table: "PokemonAbility",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMove_Pokemons_PokemonId",
                table: "PokemonMove",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonType_Pokemons_PokemonId",
                table: "PokemonType",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonType_Type_TypeId",
                table: "PokemonType",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_Type_TypeId",
                table: "Move");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonAbility_Ability_AbilityId",
                table: "PokemonAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonAbility_Pokemons_PokemonId",
                table: "PokemonAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMove_Move_MoveId",
                table: "PokemonMove");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonMove_Pokemons_PokemonId",
                table: "PokemonMove");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonType_Pokemons_PokemonId",
                table: "PokemonType");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonType_Type_TypeId",
                table: "PokemonType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Type",
                table: "Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonType",
                table: "PokemonType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonMove",
                table: "PokemonMove");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonAbility",
                table: "PokemonAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Move",
                table: "Move");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ability",
                table: "Ability");

            migrationBuilder.RenameTable(
                name: "Type",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "PokemonType",
                newName: "PokemonTypes");

            migrationBuilder.RenameTable(
                name: "PokemonMove",
                newName: "PokemonMoves");

            migrationBuilder.RenameTable(
                name: "PokemonAbility",
                newName: "PokemonAbilities");

            migrationBuilder.RenameTable(
                name: "Move",
                newName: "Moves");

            migrationBuilder.RenameTable(
                name: "Ability",
                newName: "Abilities");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonType_TypeId",
                table: "PokemonTypes",
                newName: "IX_PokemonTypes_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonMove_MoveId",
                table: "PokemonMoves",
                newName: "IX_PokemonMoves_MoveId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonAbility_AbilityId",
                table: "PokemonAbilities",
                newName: "IX_PokemonAbilities_AbilityId");

            migrationBuilder.RenameIndex(
                name: "IX_Move_TypeId",
                table: "Moves",
                newName: "IX_Moves_TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonTypes",
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonMoves",
                table: "PokemonMoves",
                columns: new[] { "PokemonId", "MoveId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonAbilities",
                table: "PokemonAbilities",
                columns: new[] { "PokemonId", "AbilityId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moves",
                table: "Moves",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities",
                column: "AbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Types_TypeId",
                table: "Moves",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonAbilities_Abilities_AbilityId",
                table: "PokemonAbilities",
                column: "AbilityId",
                principalTable: "Abilities",
                principalColumn: "AbilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonAbilities_Pokemons_PokemonId",
                table: "PokemonAbilities",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMoves_Moves_MoveId",
                table: "PokemonMoves",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonMoves_Pokemons_PokemonId",
                table: "PokemonMoves",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTypes_Pokemons_PokemonId",
                table: "PokemonTypes",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTypes_Types_TypeId",
                table: "PokemonTypes",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
