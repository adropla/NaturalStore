using Microsoft.AspNetCore.Mvc;
using NaturalStore.Domain;
using NaturalStore.Domain.Entities;
using NaturalStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly DataManager dataManager;
        private readonly ShopCart _shopCart;
        public ShopCartController(DataManager dataManager, ShopCart shopCart)
        {
            this.dataManager = dataManager;
            this._shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetCartLines();
            _shopCart.CartLines = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(Guid id)
        {
            var item = dataManager.ServiceItems.GetServiceItems().FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item, 1);
            }
            return RedirectToAction("Index");
        }

    }
}
