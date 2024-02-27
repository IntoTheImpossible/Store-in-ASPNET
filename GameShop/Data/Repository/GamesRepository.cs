using GameShop.Data.Interfaces;
using GameShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameShop.Data.Repository
{
    public class GamesRepository : IAllGames
    {
        private readonly AppDBContent _content;

        public GamesRepository(AppDBContent _content)
        {
            this._content = _content;
        }
        public IEnumerable<Game> Games => _content.DbGame.Include(c => c.Category);
        public Game getGame(int id) => _content.DbGame.FirstOrDefault(p => p.Id == id);
    }
}
 