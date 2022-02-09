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
  public  interface IInformationService
    {
        Task<ResponseResult> Add(InformationViewModel model, string token);
        Task<ResponseResult> Update(InformationViewModel model, string token);
        Task<ResponseResult> Delete(string id, string token);
        Task<VInformation> GetById(string id);
        Task<List<VInformation>> GetAll();
      

    }
}
