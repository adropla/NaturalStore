using Microsoft.AspNetCore.Mvc;
using NaturalStore.Domain.Entities;
using NaturalStore.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders orders;
        private readonly ShopCart _shopCart;
        public OrderController(IOrders orders, ShopCart shopCart)
        {
            this.orders = orders;
            this._shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.CartLines = _shopCart.GetCartLines();
            if (_shopCart.CartLines.Count == 0)
            {
                ModelState.AddModelError("", "В корзине должны быть товары");
            }

            if (ModelState.IsValid)
            {
                orders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
