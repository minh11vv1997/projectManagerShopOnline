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
using SharedObject.StoredProcedures;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CTTNDbContext _context;
        public CategoryController (CTTNDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult< List<VCategory>>> GetAll()
        {
            try
            {
                var result = await _context.Query<VCategory>().AsNoTracking().FromSql(SPCategory.cttnSP_Get_All_Category).ToListAsync();
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
        public async Task<IActionResult> Add([FromBody]CategoryViewModel model)
        {
            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPCategory.cttnSP_Add_Category, model.CategoryName, model.SeoTittle, model.SeoDescription, model.Image);
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
        public async Task<IActionResult> Update([FromBody]CategoryViewModel model)
        {
            if (await GetById(model.CategoryId) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPCategory.cttnSP_Update_Category, model.CategoryId, model.CategoryName, model.SeoTittle, model.SeoDescription, model.Image);
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
        public async Task<VCategory> GetById(string id)
        {
            var result = await _context.Query<VCategory>().AsNoTracking().FromSql(SPCategory.cttnSP_Get_Category_By_Id, id).FirstOrDefaultAsync();
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
                var result = await _context.Database.ExecuteSqlCommandAsync(SPCategory.cttnSP_Delete_Category, id);
                return Ok(new ResponseResult(200));

            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult (400));
            }

        }
    }
}