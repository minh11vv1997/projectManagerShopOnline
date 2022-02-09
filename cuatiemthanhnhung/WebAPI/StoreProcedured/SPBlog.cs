using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPBlog
    {   //blog
        public static string SP_Add_Blog = "imic_SP_Add_Blog @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12";

        public static string SP_Update_Blog = "imic_SP_Update_Blog @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11";

        public static string SP_Delete_Blog = "imic_SP_Delete_Blog @p0";

        public static string SP_Get_Blog_By_Id = "imic_SP_Get_Blog_By_Id @p0";

        public static string SP_Get_Random_Blog = "imic_SP_Get_Random_Blog";

        public static string SP_Get_Blog_By_KeyCode = "imic_SP_Get_Blog_By_KeyCode @p0";

        public static string SP_Get_Blog_Pagination = "imic_SP_Get_Blog_Pagination @p0,@p1,@p2,@p3,@p4,@p5,@p6";

        public static string SP_Count_Blog_Pagination = "imic_SP_Count_Blog_Pagination @p0 OUT,@p1,@p2,@p3,@p4,@p5";
    }
}
