using SharedObject.Commons;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using SharedObjects;


using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
  public  interface IBlogDetailService
    {
        Task<ResponseResult> Add(BlogDetailViewModel model, string token);
        Task<ResponseResult> Update(BlogDetailViewModel model, string token);
        Task<ResponseResult> Delete(string id, string token);
        Task<VBlogDetail> GetById(string id);
        Task<List<VBlogDetail>> GetByBlogId(string id);
    }
}
