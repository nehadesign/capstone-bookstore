﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.BS.Models.Entity
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
