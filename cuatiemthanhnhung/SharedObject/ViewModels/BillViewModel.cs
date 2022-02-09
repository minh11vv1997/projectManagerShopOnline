using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class BillViewModel
    {
        public string BillId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal? Total { get; set; }
        public int? Status { get; set; }
    }
}
