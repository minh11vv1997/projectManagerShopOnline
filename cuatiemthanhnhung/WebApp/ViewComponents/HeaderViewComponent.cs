using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.Extentions;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IInformationService informationService;

        public HeaderViewComponent(IInformationService informationService)
        {
            this.informationService = informationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var info = (await informationService.GetAll()).FirstOrDefault();
           
            return View(info);
        }
        
    }
}
