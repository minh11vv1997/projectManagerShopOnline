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
    public class BillService : BaseService, IBillService
    {
        public async Task<ResponseResult> Add(BillViewModel model)
        {
            
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Bill/add", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }



        public async Task<ResponseResult> Delete(string id, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();

            using (var response = await httpClient.DeleteAsync("api/Bill/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<VBill> GetById(string id)
        {
            VBill result = new VBill();

            using (var response = await httpClient.GetAsync("api/Bill/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBill>(apiResponse);
            }
            return result;
        }
      

        public async Task<List<VBill>> GetPagination(PaginationBillViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            List<VBill> results = new List<VBill>();

            using (var response = await httpClient.PostAsync("api/Bill/get-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VBill>>(apiResponse);
            }
            return results;
        }
        public async Task<int> CountPagination(PaginationBillViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            int count = 0;

            using (var response = await httpClient.PostAsync("api/Bill/count-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;

        }

        public async Task<ResponseResult> Update(BillViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/Bill/update-status", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
