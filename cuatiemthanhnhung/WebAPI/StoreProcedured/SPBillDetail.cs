using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPBillDetail
    {  
        public static string cttnSP_Add_BillDetail = "cttnSP_Add_BillDetail @p0,@p1,@p2,@p3,@p4";

        public static string cttnSP_Get_BillDetail_By_BillId = "cttnSP_Get_BillDetail_By_BillId @p0";
       
       
    }
}
