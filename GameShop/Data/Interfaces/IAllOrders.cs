using GameShop.Data.Models;
using System.Collections.Generic;

namespace GameShop.Data.Interfaces
{
    public interface IAllOrders 
    {
        IEnumerable<Order> Orders { get; }
        void createOrder(Order order);  

    }
}
