using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject.StoredProcedures
{
   public class SPCategory
    {
        public const string cttnSP_Get_All_Category = "cttnSP_Get_All_Category";

        public const string cttnSP_Add_Category = "cttnSP_Add_Category @p0,@p1,@p2,@p3";

        public const string cttnSP_Delete_Category = "cttnSP_Delete_Category @p0";

        public const string cttnSP_Get_Category_By_Id = "cttnSP_Get_Category_By_Id @p0";

        public const string cttnSP_Update_Category = "cttnSP_Update_Category @p0,@p1,@p2,@p3,@p4";

    }
}
