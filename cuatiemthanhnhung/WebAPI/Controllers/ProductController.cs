using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.StoreProcedured;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using SharedObject.Commons;
using SharedObject.StoredProcedures;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CTTNDbContext _context;
        private readonly IKeyCodeRepository _keyCodeRepository;
        public ProductController(CTTNDbContext context, IKeyCodeRepository keyCodeRepository)
        {
            _context = context;
            _keyCodeRepository = keyCodeRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("get-pagination")]
        public async Task<List<VProduct>> GetPagination([FromBody] PaginationProductViewModel model)
        {
            if (string.IsNullOrEmpty(model.CategoryId))
            {
                model.CategoryId = null;
            }
            if (string.IsNullOrEmpty(model.KeyWord))
            {
                model.KeyWord = null;
            }
            var result = await _context.Query<VProduct>().AsNoTracking().FromSql(SPProduct.cttnSP_Get_Product_Pagination, model.PageIndex, model.PageSize, model.CategoryId, model.KeyWord).ToListAsync();

            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("count-pagination")]
        public async Task<int> CountPagination([FromBody] PaginationProductViewModel model)
        {

            if (string.IsNullOrEmpty(model.CategoryId))
            {
                model.CategoryId = null;
            }
            if (string.IsNullOrEmpty(model.KeyWord))
            {
                model.KeyWord = null;
            }
            var output = new SqlParameter
            {

                DbType = DbType.Int32,
                Direction = ParameterDirection.Output
            };

            await _context.Database.ExecuteSqlCommandAsync(SPProduct.cttnSP_Count_Product_Pagination, output, model.CategoryId, model.KeyWord);
            var result = (int)output.Value;
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] ProductViewModel model)
        {

            try
            {
                int keycode = await _keyCodeRepository.GetByName(KeyCodeName.Product);
                await _context.Database.ExecuteSqlCommandAsync(SPProduct.cttnSP_Add_Product, model.ProductName, model.Summary, model.Detail, model.SeoTittle, model.SeoDescription, model.Status, model.Price, model.Image, model.CategoryId, keycode);
                await _keyCodeRepository.UpdateByName(KeyCodeName.Product);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400));
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] ProductViewModel model)
        {
            if (await GetById(model.ProductId) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPProduct.cttnSP_Update_Product, model.ProductId, model.ProductName, model.Summary, model.Detail, model.SeoTittle, model.SeoDescription, model.Status, model.Price, model.Image, model.CategoryId);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<VProduct> GetById(string id)
        {
            var result = await _context.Query<VProduct>().AsNoTracking().FromSql(SPProduct.cttnSP_Get_Product_By_Id, id).FirstOrDefaultAsync();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        
        [HttpGet("keycode/{keycode}")]
        public async Task<VProduct> GetByKeyCode(int keycode)
        {
            var result = await _context.Query<VProduct>().AsNoTracking().FromSql(SPProduct.cttnSP_Get_Product_By_KeyCode, keycode).FirstOrDefaultAsync();
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
                var result = await _context.Database.ExecuteSqlCommandAsync(SPProduct.cttnSP_Delete_Product, id);
                return Ok(new ResponseResult(200));

            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400));
            }

        }


    }
}