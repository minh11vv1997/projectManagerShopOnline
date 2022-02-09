using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ImicBlogs
    {
        public ImicBlogs()
        {
            ImicBlogDetails = new HashSet<ImicBlogDetails>();
        }

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
        public int? KeyCode { get; set; }

        public ImicBlogCategories BlogCate { get; set; }
        public ICollection<ImicBlogDetails> ImicBlogDetails { get; set; }
    }
}
