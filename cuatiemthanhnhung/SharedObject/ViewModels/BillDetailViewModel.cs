using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
  public  class BillDetailViewModel
    {
        public string BillDetailId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalMoney { get; set; }
        public byte? Status { get; set; }
        public string BillId { get; set; }
    }
}
