using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CttnBills
    {
        public CttnBills()
        {
            CttnBillDetails = new HashSet<CttnBillDetails>();
        }

        public Guid BillId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal? Total { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }

        public ICollection<CttnBillDetails> CttnBillDetails { get; set; }
    }
}
