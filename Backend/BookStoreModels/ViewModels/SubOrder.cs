﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels.ViewModels
{
    public partial class SubOrder
    {
        
        public int Bookid { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Totalprice { get; set; }
    }
}
