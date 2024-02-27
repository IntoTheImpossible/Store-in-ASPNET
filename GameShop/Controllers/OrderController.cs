using GameShop.Data;
using GameShop.Data.Interfaces;
using GameShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace GameShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _cart;
        private readonly IOrderProcess _orderProcess;
        private bool valid;

        public OrderController(IAllOrders allOrders, ShopCart cart, IOrderProcess proc)
        {
            _allOrders = allOrders;
            _cart = cart;
            _orderProcess = proc;
            valid = false;
        }

        private Order GetData(Order order)
        {
            _cart.ListShopItems = _cart.getShopItems(); 
            if (_cart.ListShopItems.Count == 0)  
            {
                ModelState.AddModelError("", "Koszyk jest pusty :("); 
            }

            if (ModelState.IsValid)
            {
                _allOrders.createOrder(order);  
                string message = order.ClientName + ", Dziękujemy za zakupy w naszym sklepie. \nTwoje zamówienie zostało utworzone:";   
                foreach (var item in order.OrderDetails)
                {
                    message += "\n" + item.game.Name + ": 0000-0000-0000-0000";
                }
                _orderProcess.SendEmail(order.Email, "Zamówienie od #" + order.Id, message);  
                valid = true;
            }
            return order;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            GetData(order);
            if(valid) return RedirectToAction("Paid");   
            return View(order);
        }

        public IActionResult Paid()   
        { 
            return View();
        }

    }
}
