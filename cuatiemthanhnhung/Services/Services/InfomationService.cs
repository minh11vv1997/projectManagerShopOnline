using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SharedObject.Commons;

namespace Services.Services
{
    public class InformationService : BaseService, IInformationService
    {
        public async Task<ResponseResult> Add(InformationViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Information/add", content))
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

            using (var response = await httpClient.DeleteAsync("api/Information/delete/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VInformation>> GetAll()
        {


            List<VInformation> results = new List<VInformation>();

            using (var response = await httpClient.GetAsync("api/Information"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VInformation>>(apiResponse);
            }
            return results;
        } 
        public async Task<List<VInformation>> GetByStatus(int status)
        {


            List<VInformation> results = new List<VInformation>();

            using (var response = await httpClient.GetAsync("api/Information/status/"+ status))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VInformation>>(apiResponse);
            }
            return results;
        }

        public async Task<VInformation> GetById(string id)
        {
            VInformation result = new VInformation();

            using (var response = await httpClient.GetAsync("api/Information/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VInformation>(apiResponse);
            }
            return result;
        }

        public async Task<VInformation> GetByKeyCode(int keycode)
        {
            VInformation result = new VInformation();

            using (var response = await httpClient.GetAsync("api/Information/keycode/" + keycode))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<VInformation>(apiResponse);
            }
            return result;
        }


        public async Task<ResponseResult> Update(InformationViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync("api/Information/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
