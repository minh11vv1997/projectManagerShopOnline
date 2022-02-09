using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
    public class VBill
    {
        public Guid BillId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal? Total { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public long? rc { get; set; }
    }
}
