using GameShop.Data.Models;
using System.Collections.Generic;

namespace GameShop.Data.Interfaces
{
    public interface IAllGames 
    {
        IEnumerable<Game> Games { get; }
        Game getGame(int id); 
    }
}
