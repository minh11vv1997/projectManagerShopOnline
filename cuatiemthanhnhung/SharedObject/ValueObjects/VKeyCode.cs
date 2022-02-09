using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
   public class VKeyCode
    {
        public Guid KeyCodeId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
