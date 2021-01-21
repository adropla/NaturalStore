using NaturalStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Domain.Repositories.Abstract
{
    public interface IOrders
    {
        void createOrder(Order order);
    }
}
