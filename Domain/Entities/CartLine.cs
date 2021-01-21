using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalStore.Domain.Entities
{
    public class CartLine
    {
        public int Id { get; set; }
        public ServiceItem ServiceItem { get; set; }
        public int Quantity { get; set; }
        public string ShopCardId { get; set; }
    }
}

