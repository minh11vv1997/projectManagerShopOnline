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
    public class BlogService : BaseService, IBlogService
    {
        public async Task<ResponseResult> Add(BlogViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/blog/add", content))
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

            using (var response = await httpClient.DeleteAsync("api/blog/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<VBlog> GetById(string id)
        {
            VBlog result = new VBlog();

            using (var response = await httpClient.GetAsync("api/blog/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBlog>(apiResponse);
            }
            return result;
        }
        public async Task<VBlog> GetRandom()
        {
            VBlog result = new VBlog();

            using (var response = await httpClient.GetAsync("api/blog/random"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBlog>(apiResponse);
            }
            return result;
        }
        public async Task<VBlog> GetByKeyCode(int keycode)
        {
            VBlog result = new VBlog();

            using (var response = await httpClient.GetAsync("api/blog/keycode/" + keycode))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBlog>(apiResponse);
            }
            return result;
        }

        public async Task<List<VBlog>> GetPagination(PaginationBlogViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            List<VBlog> results = new List<VBlog>();

            using (var response = await httpClient.PostAsync("api/blog/get-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VBlog>>(apiResponse);
            }
            return results;
        }
        public async Task<int> CountPagination(PaginationBlogViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            int count = 0;

            using (var response = await httpClient.PostAsync("api/blog/count-pagination", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;

        }

        public async Task<ResponseResult> Update(BlogViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/blog/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
