using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
   public class VBlogDetail
    {
        public Guid BlogDetailId { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Number { get; set; }
        public DateTime? DateCreated { get; set; }
        public byte? Status { get; set; }
        public Guid? BlogId { get; set; }
    }
}
