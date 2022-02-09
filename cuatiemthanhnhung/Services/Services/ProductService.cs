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
    public class ProductService : BaseService, IProductService
    {
        public async Task<ResponseResult> Add(ProductViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Product/add", content))
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

            using (var response = await httpClient.DeleteAsync("api/Product/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<VProduct> GetById(string id)
        {
            VProduct result = new VProduct();

            using (var response = await httpClient.GetAsync("api/Product/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VProduct>(apiResponse);
            }
            return result;
        }

        public async Task<VProduct> GetByKeyCode(int keycode)
        {
            VProduct result = new VProduct();

            using (var response = await httpClient.GetAsync("api/Product/keycode/" + keycode))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VProduct>(apiResponse);
            }
            return result;
        }

        public async Task<List<VProduct>> GetPagination(PaginationProductViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            List<VProduct> results = new List<VProduct>();

            using (var response = await httpClient.PostAsync("api/Product/get-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VProduct>>(apiResponse);
            }
            return results;
        }
        public async Task<int> CountPagination(PaginationProductViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            int count = 0;

            using (var response = await httpClient.PostAsync("api/Product/count-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;

        }

        public async Task<ResponseResult> Update(ProductViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/Product/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
