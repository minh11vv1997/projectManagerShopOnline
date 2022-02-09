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
  public  interface IBillService
    {
        Task<ResponseResult> Add(BillViewModel model);
        Task<ResponseResult> Update(BillViewModel model, string token);
        Task<ResponseResult> Delete(string id, string token);
        Task<VBill> GetById(string id);
        Task<List<VBill>> GetPagination(PaginationBillViewModel model);
        Task<int> CountPagination(PaginationBillViewModel model);
    }
}
