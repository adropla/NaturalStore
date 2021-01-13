using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Natural_Store.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<StoreItem> StoreItems
        {
            get { return context.StoreItems; }
        }
    }
}