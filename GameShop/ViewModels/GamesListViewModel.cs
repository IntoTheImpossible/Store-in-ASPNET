

using GameShop.Data.Models;
using System;
using System.Collections.Generic;

namespace GameShop.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> IEAllGames { get; set; }   

        public string currCategory { get; set; }    
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; } 

        public GamesListViewModel(IEnumerable<Game> games, string cat, int count, int pageNumber, int pageSize)
        {
            IEAllGames = games;
            currCategory = cat;
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);   
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);   
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);   
            }
        }
    }
}
