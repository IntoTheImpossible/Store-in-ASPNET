using GameShop.Data.Interfaces;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {

        public HomeController() { }

        public ViewResult Index()
        {
            return View();
        }
    }
}
 