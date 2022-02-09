using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class PaginationProductViewModel
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string CategoryId { get; set; }
        public string KeyWord { get; set; }

    }
}
