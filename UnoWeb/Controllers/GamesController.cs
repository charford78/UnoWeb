using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnoWeb.Models;

namespace UnoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly UnoDbContext _context;

        public GamesController(UnoDbContext context)
        {
            _context = context;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            return await _context.Games.ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, Game game)
        {
            if (id != game.Id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
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

        // POST: api/Games
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }

        // POST: api/Games/deck/3
        [HttpPost("deck/{gameId}")]
        private async Task<ActionResult<List<GameCard>>> CreateDeck (int gameId)
        {
            var gamecardctrl = new GameCardsController(context);
            
            var game = await _context.Games.FindAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var deck = new List<GameCard>();

            deck.Add(new GameCard(GameCard.Type.wild, GameCard.Color.wild, gameId));
            deck.Add(new GameCard(GameCard.Type.one, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.two, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.three, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.four, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.five, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.six, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.seven, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.eight, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.nine, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.ten, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.skip, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.reverse, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.draw2, GameCard.Color.red, gameId));
            deck.Add(new GameCard(GameCard.Type.one, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.two, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.three, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.four, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.five, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.six, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.seven, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.eight, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.nine, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.ten, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.skip, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.reverse, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.draw2, GameCard.Color.blue, gameId));
            deck.Add(new GameCard(GameCard.Type.one, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.two, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.three, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.four, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.five, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.six, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.seven, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.eight, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.nine, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.ten, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.skip, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.reverse, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.draw2, GameCard.Color.yellow, gameId));
            deck.Add(new GameCard(GameCard.Type.one, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.two, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.three, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.four, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.five, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.six, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.seven, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.eight, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.nine, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.ten, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.skip, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.reverse, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.draw2, GameCard.Color.green, gameId));
            deck.Add(new GameCard(GameCard.Type.wildDraw4, GameCard.Color.wild, gameId));

            foreach(var )
        }
    }
}
