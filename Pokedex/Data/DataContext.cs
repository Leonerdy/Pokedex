using Microsoft.EntityFrameworkCore;
using Pokedex.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }
        //public DbSet<Ability> Abilities { get; set; }
        //public DbSet<Move> Moves { get; set; }
        //public DbSet<Entities.Type> Types { get; set; }

        //public DbSet<PokemonAbility> PokemonAbilities { get; set; }
        //public DbSet<PokemonMove> PokemonMoves { get; set; }
        //public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonAbility>().HasKey(pa => new { pa.PokemonId, pa.AbilityId });

            modelBuilder.Entity<PokemonAbility>()
                .HasOne(p => p.Pokemon)
            .WithMany(ph => ph.PokemonAbilities)
            .HasForeignKey(pi => pi.PokemonId);
            modelBuilder.Entity<PokemonAbility>()
                .HasOne(a => a.Ability)
            .WithMany(ph => ph.PokemonAbilities)
            .HasForeignKey(ai => ai.AbilityId);



            modelBuilder.Entity<PokemonMove>().HasKey(pm => new { pm.PokemonId, pm.MoveId });

            modelBuilder.Entity<PokemonMove>()
                .HasOne(p => p.Pokemon)
            .WithMany(ph => ph.PokemonMoves)
            .HasForeignKey(pi => pi.PokemonId);
            modelBuilder.Entity<PokemonMove>()
                .HasOne(m => m.Move)
            .WithMany(pm => pm.PokemonMoves)
            .HasForeignKey(mi => mi.MoveId);

            modelBuilder.Entity<PokemonType>().HasKey(pt => new { pt.PokemonId, pt.TypeId });

            modelBuilder.Entity<PokemonType>()
                .HasOne(p => p.Pokemon)
            .WithMany(pt => pt.PokemonTypes)
            .HasForeignKey(pi => pi.PokemonId);
            modelBuilder.Entity<PokemonType>()
                .HasOne(t => t.Type)
            .WithMany(pt => pt.PokemonTypes)
            .HasForeignKey(ti => ti.TypeId);
        }

    }
}
