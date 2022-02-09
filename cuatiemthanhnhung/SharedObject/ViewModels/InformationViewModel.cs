using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.ViewModels
{
  public  class InformationViewModel
    {
        public string InformationId { get; set; }
        public string OfficeName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? Status { get; set; }
        public int? Position { get; set; }

    }
}
