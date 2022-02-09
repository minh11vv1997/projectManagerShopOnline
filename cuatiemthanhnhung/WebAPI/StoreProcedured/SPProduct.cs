using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.StoredProcedures
{
    public class SPProduct
    {

        public const string cttnSP_Get_Product_Pagination = "cttnSP_Get_Product_Pagination @p0,@p1,@p2,@p3";

        public const string cttnSP_Count_Product_Pagination = "cttnSP_Count_Product_Pagination @p0 OUT,@p1,@p2";

        public const string cttnSP_Get_Product_By_Id = "cttnSP_Get_Product_By_Id @p0";

        public const string cttnSP_Get_Product_By_KeyCode = "cttnSP_Get_Product_By_KeyCode @p0";

        public const string cttnSP_Delete_Product = "cttnSP_Delete_Product @p0";

        public const string cttnSP_Update_Product = "cttnSP_Update_Product @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";

        public const string cttnSP_Add_Product = "cttnSP_Add_Product @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
    }
}
