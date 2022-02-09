using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CttnCategories
    {
        public CttnCategories()
        {
            CttnProducts = new HashSet<CttnProducts>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SeoTittle { get; set; }
        public string SeoDescription { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Image { get; set; }

        public ICollection<CttnProducts> CttnProducts { get; set; }
    }
}
