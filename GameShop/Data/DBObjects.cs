using GameShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameShop.Data
{
    public class DBObjects
    {
        public static void Initialize(AppDBContent content) 
        {

            if (!content.DbCategory.Any())
            {
                content.DbCategory.AddRange(DictCategories.Select(c => c.Value)); 
            }

            if (!content.DbGame.Any()) 
            {
                content.AddRange(
                    new Game { Image = "/img/css.jpg", Name = "Counter-Strike: Source", Desc = "Ponadczasowa drużynowa strzelanka taktyczna", Details = "", TechReq = "", IsAvailable = true, Quantity = 15, Price = 300, Category = DictCategories["Action"] },
                    new Game { Image = "/img/RE2.jpg", Name = "Resident Evil 2", Desc = "Remake prawdziwego horroru", Details = "", TechReq = "", IsAvailable = true, Quantity = 20, Price = 100, Category = DictCategories["Horror"] },
                    new Game { Image = "/img/ylad.jpg", Name = "Yakuza: Like a Dragon", Desc = "Ósma odsłona legendarnej serii JRPG", Details = "", TechReq = "", IsAvailable = true, Quantity = 10, Price = 350, Category = DictCategories["JRPG"] },
                    new Game { Image = "/img/cp2077.jpg", Name = "Cyberpunk 2077", Desc = "Polska gra na światowym poziomie", Details = "", TechReq = "", IsAvailable = true, Quantity = 15, Price = 250, Category = DictCategories["Action"] },
                    new Game { Image = "/img/os.jpg", Name = "One Shot", Desc = "Surrealistyczna gra przygodowa", Details = "", TechReq = "", IsAvailable = true, Quantity = 7, Price = 50, Category = DictCategories["Quest"] } ,
                    new Game { Image = "/img/for.jpg", Name = "FORSPOKEN", Desc = "Poznaj historie Athi!", Details = "", TechReq = "", IsAvailable = true, Quantity = 7, Price = 120, Category = DictCategories["Quest"] }) ;
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> DictCategories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Action", CategoryDesc = "Dla tych, którzy chcą przejść przez ten sam moment tysiąc razy" },
                        new Category { CategoryName = "Horror", CategoryDesc = "Dla tych, którzy lubią łaskotać nerwy" },
                        new Category { CategoryName = "JRPG", CategoryDesc = "Japońskie gry RPG" },
                        new Category { CategoryName = "RPG", CategoryDesc = "Gatunek oparty na elementach stołowych gier fabularnych" },
                        new Category { CategoryName = "Quest", CategoryDesc = "Sztuka tworzenia interaktywnych historii" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category c in list)
                        category.Add(c.CategoryName, c);
                }

                return category;
            }
        }
    }
}
