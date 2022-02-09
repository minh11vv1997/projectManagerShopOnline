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
  public  interface IBlogService
    {
        Task<ResponseResult> Add(BlogViewModel model, string token);
        Task<ResponseResult> Update(BlogViewModel model, string token);
        Task<ResponseResult> Delete(string id, string token);
        Task<VBlog> GetById(string id);
        Task<VBlog> GetRandom();
        Task<VBlog> GetByKeyCode(int keycode);
        Task<List<VBlog>> GetPagination(PaginationBlogViewModel model);
        Task<int> CountPagination(PaginationBlogViewModel model);
    }
}
