using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using WebAPI.Models;
using WebAPI.StoreProcedured;
using SharedObject.Commons;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController : ControllerBase
    {
        private readonly CTTNDbContext _context;
        public BlogCategoryController(CTTNDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult< List<VBlogCategory>>> GetAll()
        {
            try
            {
                var result = await _context.Query<VBlogCategory>().AsNoTracking().FromSql(SPBlogCategory.Get_All_BlogCategories).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
            

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]BlogCategoryViewModel model)
        {
            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBlogCategory.SP_Add_BlogCategory, model.BlogCateName, model.SeoTittle, model.SeoDescription);
                return Ok(new ResponseResult (200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult (400));
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("update")]
    
        public async Task<IActionResult> Update([FromBody]BlogCategoryViewModel model)
        {
            if (await this.GetById(model.BlogCateId) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBlogCategory.SP_Update_BlogCategory, model.BlogCateId, model.BlogCateName, model.SeoTittle, model.SeoDescription);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult (400));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<VBlogCategory> GetById(string id)
        {
            var result = await _context.Query<VBlogCategory>().AsNoTracking().FromSql(SPBlogCategory.SP_Get_BlogCategory_By_Id, id).FirstOrDefaultAsync();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {

            if (await this.GetById(id) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                var result = await _context.Database.ExecuteSqlCommandAsync(SPBlogCategory.SP_Delete_BlogCategory, id);
                return Ok(new ResponseResult(200));

            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult (400));
            }

        }
    }
}