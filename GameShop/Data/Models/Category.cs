using System.Collections.Generic;

namespace GameShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; }    
        public string CategoryDesc { get; set; }    
        public List<Game> Games { get; set; }   

    }
}
