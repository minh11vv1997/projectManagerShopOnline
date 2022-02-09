using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class CategoryViewModel
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public byte? Status { get; set; }
        public string Image { get; set; }
    }
}
