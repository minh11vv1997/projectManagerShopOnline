using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.StoreProcedured;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects;
using SharedObject.ValueObjects;
using SharedObject.ViewModels;
using SharedObject.Commons;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDetailController : ControllerBase
    {
        private readonly CTTNDbContext _context;
        public BlogDetailController(CTTNDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]BlogDetailViewModel model)
        {
            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBlogDetail.SP_Add_BlogDetail, model.Tittle, model.Content,  model.Number, model.BlogId);
                return Ok(new ResponseResult (200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400));
            }

        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody]BlogDetailViewModel model)
        {
            if (await this.GetById(model.BlogDetailId) == null)
            {
                return NotFound(new ResponseResult (404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBlogDetail.SP_Update_BlogDetail,model.BlogDetailId, model.Tittle, model.Content, model.Number);
                return Ok(new ResponseResult (200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult (400));
            }
        }
        [HttpGet("{id}")]
        public async Task<VBlogDetail> GetById(string id)
        {
            var result = await _context.Query<VBlogDetail>().AsNoTracking().FromSql(SPBlogDetail.SP_Get_BlogDetail_By_Id, id).FirstOrDefaultAsync();
            return result;
        }

        [HttpGet("get-by-blog/{id}")]
        public async Task<List<VBlogDetail>> GetByCourseId(string id)
        {
            var results = await _context.Query<VBlogDetail>().AsNoTracking().FromSql(SPBlogDetail.SP_Get_BlogDetail_By_BlogId, id).ToListAsync();
            return results;
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
                return NotFound(new ResponseResult (200));
            }

            try
            {
                var result = await _context.Database.ExecuteSqlCommandAsync(SPBlogDetail.SP_Delete_BlogDetail, id);
                return Ok(new ResponseResult (400));

            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult (400));
            }

        }
    }
}