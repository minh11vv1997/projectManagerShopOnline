using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
    public class BlogDetailViewModel
    {
        public string BlogDetailId { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Number { get; set; }
        public int? Status { get; set; }
        public string BlogId { get; set; }

    }
}
