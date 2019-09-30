using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Data;
using Pokedex.Data.Entities;


namespace Pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly DataContext _context;

        public PokemonsController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {
            try
            {
                var pokemons = _context.Pokemons
                   .Include(p => p.PokemonTypes)
                   .ThenInclude(t => t.Type)
                   .Include(p => p.PokemonMoves)
                   .ThenInclude(t => t.Move)
                   .Include(p => p.PokemonAbilities)
                   .ThenInclude(t => t.Ability);

                return await pokemons.ToListAsync();
            }
            catch (Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int? id)
        {
            try
            {
                var pokemon = await _context.Pokemons
                     .Include(p => p.PokemonTypes)
                     .ThenInclude(t => t.Type)
                     .Include(p => p.PokemonMoves)
                     .ThenInclude(t => t.Move)
                     .Include(p => p.PokemonAbilities)
                     .ThenInclude(t => t.Ability)
                     .FirstOrDefaultAsync(o => o.PokemonId == id.Value);


                if (pokemon == null)
                {
                    return NotFound();
                }

                return pokemon;
            }catch (Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPokemon(int id, Pokemon pokemon)
        {
            if (id != pokemon.PokemonId)
            {
                return BadRequest();
            }

            _context.Entry(pokemon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Pokemon>> PostPokemon(Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                _context.Pokemons.Add(pokemon);
                await _context.SaveChangesAsync();
            }
               

            return CreatedAtAction("GetPokemon", new { id = pokemon.PokemonId }, pokemon);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Pokemon>> DeletePokemon(int id)
        {
            
                var pokemon = await _context.Pokemons.FindAsync(id);
                if (pokemon == null)
                {
                    return NotFound();
                }

                _context.Pokemons.Remove(pokemon);
                await _context.SaveChangesAsync();
            
            return pokemon;
        }

        private bool PokemonExists(int id)
        {
            return _context.Pokemons.Any(e => e.PokemonId == id);
        }
    }
}
