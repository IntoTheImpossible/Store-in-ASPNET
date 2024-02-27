namespace GameShop.Data.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; } 
        public string Details { get; set; } 
        public string TechReq { get; set; } 
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; }
        public ushort Price { get; set; } 
        public int CategoryId { get; set; } 
        public virtual Category Category { get; set; }  
    }
}
