using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPBill
    {  
        public static string cttnSP_Add_Bill = "cttnSP_Add_Bill @p0,@p1,@p2,@p3,@p4,@p5";

        public static string cttnSP_Update_Bill_Status = "cttnSP_Update_Bill_Status @p0,@p1";

        public static string cttnSP_Delete_Bill = "cttnSP_Delete_Bill @p0";

        public static string cttnSP_Get_Bill_By_BillId = "cttnSP_Get_Bill_By_BillId @p0";
       
        public static string cttnSP_Get_Bill_Pagination = "cttnSP_Get_Bill_Pagination @p0,@p1,@p2,@p3,@p4";

        public static string cttnSP_Count_Bill_Pagination = "cttnSP_Count_Bill_Pagination @p0 OUT,@p1,@p2,@p3";
    }
}
