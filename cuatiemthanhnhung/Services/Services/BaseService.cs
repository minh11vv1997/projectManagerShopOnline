using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WebAPI.Models;

namespace Services.Services
{
    public class BaseService
    {
        protected  HttpClient httpClient;
        
        public BaseService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44379/");
        }
    }
}
