using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObjects
{
   public class DateTimeService
    {
        public static string FormatDateTime(DateTime date)
        {
           string rs = date.ToString("dd/MM/yyyy");
            return rs;
        }

    }
}
