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
    public interface IBillDetailService
    {
        Task<ResponseResult> Add(List<BillDetailViewModel> model);
        Task<List<VBillDetail>> GetByBillId(string id);

    }
}
