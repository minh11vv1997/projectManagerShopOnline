using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects;
using SharedObject.ValueObjects;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SharedObject.Commons;
using SharedObject.ViewModels;

namespace Services.Services
{
    public class BillDetailService : BaseService, IBillDetailService
    {
        public async Task<ResponseResult> Add(List<BillDetailViewModel> model)
        {
           
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/BillDetail/add", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VBillDetail>> GetByBillId(string id)
        {
            List<VBillDetail> result = new List<VBillDetail>();

            using (var response = await httpClient.GetAsync("api/BillDetail/get-by-bill/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<VBillDetail>>(apiResponse);
            }
            return result;
        }



    }
}
