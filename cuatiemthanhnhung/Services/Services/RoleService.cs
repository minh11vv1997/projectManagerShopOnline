using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class RoleService : BaseService, IRoleService
    {
        public async Task<ResponseResult> Add(RoleViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/role/add", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> AssignRole(UserRoleViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync(requestUri: "api/role/assign-role", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Delete(string roleName, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();

            using (var response = await httpClient.DeleteAsync("api/role/" + roleName))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<IdentityRole>> GetAll(string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<IdentityRole> roles = new List<IdentityRole>();

            using (var response = await httpClient.GetAsync("api/role/get-all"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                roles = JsonConvert.DeserializeObject<List<IdentityRole>>(apiResponse);
            }
            return roles;
        }

        public async Task<IdentityRole> GetById(string token, string RoleId)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            IdentityRole role = new IdentityRole();

            using (var response = await httpClient.GetAsync("api/role/" + RoleId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                role = JsonConvert.DeserializeObject<IdentityRole>(apiResponse);
            }
            return role;
        }

        public async Task<List<IdentityUser>> GetUsersInRole(string roleName, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<IdentityUser> users = new List<IdentityUser>();

            using (var response = await httpClient.GetAsync("api/role/get-users-in-role/" + roleName))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<List<IdentityUser>>(apiResponse);
            }
            return users;
        }

        public async Task<List<IdentityUser>> GetUsersNotInRole(string roleName, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<IdentityUser> users = new List<IdentityUser>();

            using (var response = await httpClient.GetAsync("api/role/get-users-not-in-role/" + roleName))
            {
                ;
                string apiResponse = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<List<IdentityUser>>(apiResponse);
            }
            return users;
        }

        public async Task<ResponseResult> RemoveRole(UserRoleViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync(requestUri: "api/role/remove-role", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Update(RoleViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync(requestUri: "api/role/update", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
