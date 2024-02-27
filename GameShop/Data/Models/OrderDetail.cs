using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public int Price { get; set; } 
        public Game game { get; set; }
        public virtual Order Order { get; set; }    
    }
}