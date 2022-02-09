using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
    public class VCategory
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Image { get; set; }
    }
}
