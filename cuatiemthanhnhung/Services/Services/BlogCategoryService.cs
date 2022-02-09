using Newtonsoft.Json;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Services.Services
{
    public class BlogCategoryService : BaseService, IBlogCategoryService
    {
        public async Task<ResponseResult> Add(BlogCategoryViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/blogcategory/add", content))
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

            using (var response = await httpClient.DeleteAsync("api/blogcategory/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VBlogCategory>> GetAll()
        {


            List<VBlogCategory> results = new List<VBlogCategory>();

            using (var response = await httpClient.GetAsync("api/blogcategory"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VBlogCategory>>(apiResponse);
            }
            return results;
        }

        public async Task<VBlogCategory> GetById(string id)
        {
            VBlogCategory result = new VBlogCategory();

            using (var response = await httpClient.GetAsync("api/blogcategory/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VBlogCategory>(apiResponse);
            }
            return result;
        }


        public async Task<ResponseResult> Update(BlogCategoryViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/blogcategory/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
