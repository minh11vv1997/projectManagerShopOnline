using SharedObject.Commons;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductService
    {
        Task<ResponseResult> Add(ProductViewModel model, string token);
        Task<ResponseResult> Update(ProductViewModel model, string token);
        Task<ResponseResult> Delete(string id, string token);
        Task<VProduct> GetById(string id);
     
        Task<VProduct> GetByKeyCode(int keycode);
        Task<List<VProduct>> GetPagination(PaginationProductViewModel model);
        Task<int> CountPagination(PaginationProductViewModel model);
    }
}
