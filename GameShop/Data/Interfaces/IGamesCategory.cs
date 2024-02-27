using GameShop.Data.Models;
using System.Collections.Generic;

namespace GameShop.Data.Interfaces
{
    public interface IGamesCategory 
    {
        IEnumerable<Category> Categories { get; }
    }
}
