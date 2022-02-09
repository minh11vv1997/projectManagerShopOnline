using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class PaginationBillViewModel
    {

        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public int ? Status { get; set; }

    }
}
