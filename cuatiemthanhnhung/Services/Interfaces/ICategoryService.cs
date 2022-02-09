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
  public  interface ICategoryService
    {
        Task<ResponseResult> Add(CategoryViewModel model, string token);
        Task<ResponseResult> Update(CategoryViewModel model, string token);
        Task<ResponseResult> Delete( string id, string token);
        Task<List<VCategory>> GetAll();
        Task<VCategory> GetById(string id);
    }
}
