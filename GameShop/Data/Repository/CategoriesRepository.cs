using GameShop.Data.Interfaces;
using GameShop.Data.Models;
using System.Collections.Generic;

namespace GameShop.Data.Repository
{
    public class CategoriesRepository : IGamesCategory
    {
        private readonly AppDBContent _content;

        public CategoriesRepository(AppDBContent _content)
        {
            this._content = _content;
        }

        public IEnumerable<Category> Categories => _content.DbCategory;
    }
}
 