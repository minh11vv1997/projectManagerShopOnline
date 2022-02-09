using SharedObject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
   public class ShoppingCartViewModel
    {
        public VProduct Product { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal ? TotalMoney { get; set; }
    }
}
