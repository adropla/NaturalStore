using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Natural_Store.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<StoreItem> StoreItems { get; set; }
    }
}