﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Natural_Store.Models
{
    public class StoreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}