using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CttnBillDetails
    {
        public Guid BillDetailId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalMoney { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? BillId { get; set; }

        public CttnBills Bill { get; set; }
    }
}
