using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
  public  class VBlogCategory
    {
        public Guid BlogCateId { get; set; }
        public string BlogCateName { get; set; }
        public DateTime? DateCreated { get; set; }
        public byte? Status { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
    }
}
