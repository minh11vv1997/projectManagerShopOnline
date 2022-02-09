using Newtonsoft.Json;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObjects;
using SharedObject.ValueObjects;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SharedObject.ViewModels;

namespace Services.Services
{
   public class BlogDetailService : BaseService, IBlogDetailService
    {
        public async Task<ResponseResult> Add(BlogDetailViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/BlogDetail/add", content))
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

            using (var response = await httpClient.DeleteAsync("api/BlogDetail/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
      
        public async Task<VBlogDetail> GetById(string id)
        {
            VBlogDetail result = new VBlogDetail();

            using (var response = await httpClient.GetAsync("api/BlogDetail/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBlogDetail>(apiResponse);
            }
            return result;
        }

        public async Task<List<VBlogDetail>> GetByBlogId(string id)
        {
            List<VBlogDetail> results = new List<VBlogDetail>();

            using (var response = await httpClient.GetAsync("api/BlogDetail/get-by-blog/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VBlogDetail>>(apiResponse);
            }
            return results;
        }


        public async Task<ResponseResult> Update(BlogDetailViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/BlogDetail/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
