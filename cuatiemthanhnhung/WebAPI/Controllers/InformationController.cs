using System;
using System.Collections.Generic;
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
    public class InformationController : ControllerBase
    {
        private readonly CTTNDbContext _context;

        public InformationController(CTTNDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<List<VInformation>> GetAll()
        {
            var result = await _context.Query<VInformation>().AsNoTracking().FromSql(SPInfomation.SP_Get_All_Information).ToListAsync();
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] InformationViewModel model)
        {
            try
            {

                await _context.Database.ExecuteSqlCommandAsync(SPInfomation.SP_Add_Information, model.OfficeName, model.Mobile, model.Email, model.Address, model.Status, model.Position);

                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(404));
            }

        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] InformationViewModel model)
        {
            if (await this.GetById(model.InformationId) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPInfomation.SP_Update_Information, model.InformationId, model.OfficeName, model.Mobile, model.Email, model.Address, model.Status, model.Position);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(404));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<VInformation>> GetById(string id)
        {
            try
            {
                var result = await _context.Query<VInformation>().AsNoTracking().FromSql(SPInfomation.SP_Get_Information_By_Id, id).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }

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
                var result = await _context.Database.ExecuteSqlCommandAsync(SPInfomation.SP_Delete_Infomation, id);
                return Ok(new ResponseResult(404));

            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(404));
            }

        }

    }
}