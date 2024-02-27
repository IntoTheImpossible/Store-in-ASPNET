using GameShop.Data.Interfaces;
using GameShop.Data.Models;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;

namespace GameShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllGames _gamesRep; 
        private readonly ShopCart _shopCart;   

        public ShopCartController(IAllGames gamesRep, ShopCart shopCart)
        {
            _gamesRep = gamesRep;
            _shopCart = shopCart;
        }

        [HttpGet]
        public ViewResult Index()   
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel { shopCart = _shopCart };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id) 
        {
            var item = _gamesRep.Games.FirstOrDefault(i => i.Id == id);
            if(item != null && item.IsAvailable)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");   
        }

        public RedirectToActionResult deleteFromCart(int id)    
        {
            _shopCart.DeleteFromCart(id);
            return RedirectToAction("Index");
        }

    }
}
