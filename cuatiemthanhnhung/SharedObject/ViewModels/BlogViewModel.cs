using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
   public class BlogViewModel
    {

        public string BlogId { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public string BlogImage { get; set; }
        public string BackGround { get; set; }
        public string Summary { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
        public string BlogCateId { get; set; }
        public int Seen { get; set; }

    }
}
