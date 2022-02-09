using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public byte? Status { get; set; }
        public string CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }

    }
}
