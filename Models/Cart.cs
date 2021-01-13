using System.Collections.Generic;
using System.Linq;

namespace Natural_Store.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(StoreItem storeItem, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.StoreItem.StoreItemId == storeItem.StoreItemId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    StoreItem = storeItem,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(StoreItem storeItem)
        {
            lineCollection.RemoveAll(l => l.StoreItem.StoreItemId == storeItem.storeItem);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.StoreItem.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public StoreItem StoreItem { get; set; }
        public int Quantity { get; set; }
    }
}
