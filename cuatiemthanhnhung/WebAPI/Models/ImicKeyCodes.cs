using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ImicKeyCodes
    {
        public Guid KeyCodeId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
    }
}
