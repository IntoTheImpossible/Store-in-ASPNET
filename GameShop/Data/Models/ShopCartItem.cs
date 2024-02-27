namespace GameShop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Game Game { get; set; } 
        public string ShopCartId { get; set; }
    }
} 
