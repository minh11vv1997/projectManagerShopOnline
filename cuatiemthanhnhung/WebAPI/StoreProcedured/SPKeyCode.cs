using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPKeyCode
    {
        public static string SP_Get_KeyCode_By_Name = "imic_SP_Get_KeyCode_By_Name @p0";
        public static string SP_Update_KeyCode_By_Name = "imic_SP_Update_KeyCode_By_Name @p0";
    }
}
