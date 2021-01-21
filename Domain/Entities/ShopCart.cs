using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Domain.Entities
{
    public class ShopCart
    {
        private readonly AppDbContext context;
        public ShopCart(AppDbContext context)
        {
            this.context = context;
        }
        public string ShopCartId { get; set; }
        public List<CartLine> CartLines { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            
            session.SetString("CardId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(ServiceItem serviceItem, int amount)
        {
            context.CartLines.Add(new CartLine
            {
                ShopCardId = ShopCartId,
                ServiceItem = serviceItem,
                Quantity = amount
            });

            context.SaveChanges();
        }

        public decimal ComputeTotalValue()
        {
            return GetCartLines().Sum(e => e.ServiceItem.Price * e.Quantity);

        }
        public List<CartLine> GetCartLines()
        {
            return context.CartLines.Where(c => c.ShopCardId == ShopCartId).Include(s => s.ServiceItem).ToList();
        }
    }
}
