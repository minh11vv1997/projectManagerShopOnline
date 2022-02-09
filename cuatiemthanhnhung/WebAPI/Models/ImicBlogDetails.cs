using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ImicBlogDetails
    {
        public Guid BlogDetailId { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreated { get; set; }
        public byte? Status { get; set; }
        public Guid? BlogId { get; set; }
        public string Tittle { get; set; }
        public int? Number { get; set; }

        public ImicBlogs Blog { get; set; }
    }
}
