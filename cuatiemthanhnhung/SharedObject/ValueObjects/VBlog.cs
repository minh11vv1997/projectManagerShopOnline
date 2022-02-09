using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
   public class VBlog
    {
        public Guid BlogId { get; set; }
        public int? Seen { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreated { get; set; }
        public byte? Status { get; set; }
        public string BlogImage { get; set; }
        public Guid? BlogCateId { get; set; }
        public string BackGround { get; set; }
        public string Summary { get; set; }
        public string UserId { get; set; }
        public string BlogCateName { get; set; }
        public string UserName { get; set; }
        public int? KeyCode { get; set; }
        public Nullable<long> rc { get; set; }
    }
}
