using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.StoreProcedured
{
    public class SPInfomation
    {
        //@officeName NVARCHAR(100),
        //@mobile NVARCHAR(100), 
        //@email NVARCHAR(100),
        //@address NVARCHAR(500),
        //@status INT,
        //@position int
        public static string SP_Add_Information = "imic_SP_Add_Information @p0,@p1,@p2,@p3,@p4,@p5";
        //id NVARCHAR(50)
        //@officeName NVARCHAR(100),
        //@mobile NVARCHAR(100), 
        //@email NVARCHAR(100),
        //@address NVARCHAR(500),
        //@status INT,
        //@position int
        public static string SP_Update_Information = "imic_SP_Update_Information @p0,@p1,@p2,@p3,@p4,@p5,@p6";


        public static string SP_Delete_Infomation = "imic_SP_Delete_Information @p0";


        public static string SP_Get_Information_By_Id = "imic_SP_Get_Information_By_Id @p0";

        public static string SP_Get_All_Information = "imic_SP_Get_All_Information";
    }
}
