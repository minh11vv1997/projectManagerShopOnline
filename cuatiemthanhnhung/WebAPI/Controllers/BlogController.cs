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

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly CTTNDbContext _context;
        private readonly IKeyCodeRepository _keyCodeRepository;
        public BlogController(CTTNDbContext context, IKeyCodeRepository keyCodeRepository)
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
        public async Task<List<VBlog>> GetPagination([FromBody] PaginationBlogViewModel model)
        {
            var model1 = this.CheckPaginationBlogViewModel(model);
            var result = await _context.Query<VBlog>().AsNoTracking().FromSql(SPBlog.SP_Get_Blog_Pagination, model1.PageIndex, model1.PageSize, model1.BlogCateId, model1.KeyWord, model1.FromTime, model1.ToTime, model1.Status).ToListAsync();

            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("count-pagination")]
        public async Task<int> CountPagination([FromBody] PaginationBlogViewModel model)
        {

            var model1 = this.CheckPaginationBlogViewModel(model);
            var output = new SqlParameter
            {

                DbType = DbType.Int32,
                Direction = ParameterDirection.Output
            };

            await _context.Database.ExecuteSqlCommandAsync(SPBlog.SP_Count_Blog_Pagination, output, model1.BlogCateId, model1.KeyWord, model1.FromTime, model1.ToTime, model1.Status);
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
        public async Task<IActionResult> Add([FromBody]BlogViewModel model)
        {

            try
            {
                int keycode = await _keyCodeRepository.GetByName(KeyCodeName.Blog);
                await _context.Database.ExecuteSqlCommandAsync(SPBlog.SP_Add_Blog, model.BlogId, model.Tittle, model.Summary, model.Content, model.SeoTittle, model.SeoDescription, model.Status, model.BlogImage, model.BackGround, model.BlogCateId, model.UserId, keycode, model.Seen);
                await _keyCodeRepository.UpdateByName(KeyCodeName.Blog);
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
        public async Task<IActionResult> Update([FromBody]BlogViewModel model)
        {
            if (await this.GetById(model.BlogId) == null)
            {
                return NotFound(new ResponseResult (404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBlog.SP_Update_Blog, model.BlogId, model.Tittle, model.Summary, model.Content, model.SeoTittle, model.SeoDescription, model.Status, model.BlogImage, model.BackGround, model.BlogCateId, model.UserId, model.Seen);
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<VBlog> GetById(string id)
        {
            var result = await _context.Query<VBlog>().AsNoTracking().FromSql(SPBlog.SP_Get_Blog_By_Id, id).FirstOrDefaultAsync();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("random")]
        public async Task<VBlog> GetRandom()
        {
            var result = await _context.Query<VBlog>().AsNoTracking().FromSql(SPBlog.SP_Get_Random_Blog).FirstOrDefaultAsync();
            return result;
        }
        [HttpGet("keycode/{keycode}")]
        public async Task<VBlog> GetByKeyCode(int keycode)
        {
            var result = await _context.Query<VBlog>().AsNoTracking().FromSql(SPBlog.SP_Get_Blog_By_KeyCode, keycode).FirstOrDefaultAsync();
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
                return NotFound(new ResponseResult (404));
            }

            try
            {
                var result = await _context.Database.ExecuteSqlCommandAsync(SPBlog.SP_Delete_Blog, id);
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
        //Tool
        private PaginationBlogViewModel CheckPaginationBlogViewModel(PaginationBlogViewModel model)
        {

            if (string.IsNullOrEmpty(model.KeyWord))
            {
                model.KeyWord = null;
            }
            if (string.IsNullOrEmpty(model.FromTime) || string.IsNullOrEmpty(model.ToTime))
            {
                model.FromTime = null;
                model.ToTime = null;
            }
            if (string.IsNullOrEmpty(model.BlogCateId))
            {
                model.BlogCateId = null;
            }

            return model;
        }
    }
}