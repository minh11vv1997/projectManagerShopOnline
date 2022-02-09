using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CttnProducts
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public int? KeyCode { get; set; }

        public CttnCategories Category { get; set; }
    }
}
