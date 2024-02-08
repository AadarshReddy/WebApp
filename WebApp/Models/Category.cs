﻿using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
