using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ValueObjects
{
    public class VInformation
    {

        public Guid InformationId { get; set; }
        public string OfficeName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public byte? Status { get; set; }
        public int? Position { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
