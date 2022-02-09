using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPBlogCategory
    { //blog category
        public static string SP_Add_BlogCategory = "imic_SP_Add_BlogCategory @p0,@p1,@p2";

        public static string SP_Update_BlogCategory = "imic_SP_Update_BlogCategory @p0,@p1,@p2,@p3";

        public static string Get_All_BlogCategories = "imic_SP_Get_All_BlogCategories";

        public static string SP_Get_BlogCategory_By_Id = "imic_SP_Get_BlogCategory_By_Id @p0";

        public static string SP_Delete_BlogCategory = "imic_SP_Delete_BlogCategory @p0";
    }
}
