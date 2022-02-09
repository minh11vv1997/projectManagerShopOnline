using SharedObjects;
using SharedObject.ValueObjects;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SharedObject.ViewModels;
using SharedObject.Commons;

namespace Services.Interfaces
{
  public  interface IBlogCategoryService
    {
        Task<ResponseResult> Add(BlogCategoryViewModel model, string token);
        Task<ResponseResult> Update(BlogCategoryViewModel model, string token);
        Task<ResponseResult> Delete( string id, string token);
        Task<List<VBlogCategory>> GetAll();
        Task<VBlogCategory> GetById(string id);
    }
}
