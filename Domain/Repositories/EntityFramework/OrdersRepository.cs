using NaturalStore.Domain.Entities;
using NaturalStore.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Domain.Repositories.EntityFramework
{
    public class OrdersRepository : IOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopCart _shopCart;
        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this._shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);

            var items = _shopCart.CartLines;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ServiceID = el.ServiceItem.Id,
                    OrderId = order.Id,
                    Price = el.ServiceItem.Price
                };
                appDbContext.OrderDetail.Add(orderDetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
