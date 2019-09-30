﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.Data;

namespace Pokedex.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190925221744_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pokedex.Data.Entities.Ability", b =>
                {
                    b.Property<int>("AbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbilityId");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("PokemonId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonAbility", b =>
                {
                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId", "AbilityId");

                    b.HasIndex("AbilityId");

                    b.ToTable("PokemonAbilities");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonMove", b =>
                {
                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("MoveId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId", "MoveId");

                    b.HasIndex("MoveId");

                    b.ToTable("PokemonMoves");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonType", b =>
                {
                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId", "TypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.Move", b =>
                {
                    b.HasOne("Pokedex.Data.Entities.Type", "Type")
                        .WithMany("Moves")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonAbility", b =>
                {
                    b.HasOne("Pokedex.Data.Entities.Ability", "Ability")
                        .WithMany("PokemonAbilities")
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Data.Entities.Pokemon", "Pokemon")
                        .WithMany("PokemonAbilities")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonMove", b =>
                {
                    b.HasOne("Pokedex.Data.Entities.Move", "Move")
                        .WithMany("PokemonMoves")
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Data.Entities.Pokemon", "Pokemon")
                        .WithMany("PokemonMoves")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokedex.Data.Entities.PokemonType", b =>
                {
                    b.HasOne("Pokedex.Data.Entities.Pokemon", "Pokemon")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Data.Entities.Type", "Type")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
