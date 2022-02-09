using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ImicBlogCategories
    {
        public ImicBlogCategories()
        {
            ImicBlogs = new HashSet<ImicBlogs>();
        }

        public Guid BlogCateId { get; set; }
        public string BlogCateName { get; set; }
        public DateTime? DateCreated { get; set; }
        public byte? Status { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }

        public ICollection<ImicBlogs> ImicBlogs { get; set; }
    }
}
