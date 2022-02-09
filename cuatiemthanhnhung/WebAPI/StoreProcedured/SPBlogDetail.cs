using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPBlogDetail
    {
        //course BlogDetail
        public static string SP_Add_BlogDetail = "imic_SP_Add_BlogDetail @p0,@p1,@p2,@p3";

        public static string SP_Update_BlogDetail = "imic_SP_Update_BlogDetail @p0,@p1,@p2,@p3";

        public static string SP_Delete_BlogDetail = "imic_SP_Delete_BlogDetail @p0";

        public static string SP_Get_BlogDetail_By_BlogId = "imic_SP_Get_BlogDetail_By_BlogId @p0";

        public static string SP_Get_BlogDetail_By_Id = "imic_SP_Get_BlogDetail_By_Id @p0";
    }
}
