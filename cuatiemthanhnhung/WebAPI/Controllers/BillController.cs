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
    public class BillController : ControllerBase
    {
        private readonly CTTNDbContext _context;

        public BillController(CTTNDbContext context)
        {
            _context = context;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("get-pagination")]
        public async Task<List<VBill>> GetPagination([FromBody] PaginationBillViewModel model)
        {
            var model1 = this.CheckPaginationBillViewModel(model);
            var result = await _context.Query<VBill>().AsNoTracking().FromSql(SPBill.cttnSP_Get_Bill_Pagination, model1.PageIndex, model1.PageSize, model1.FromTime, model1.ToTime, model1.Status).ToListAsync();

            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("count-pagination")]
        public async Task<int> CountPagination([FromBody] PaginationBillViewModel model)
        {

            var model1 = this.CheckPaginationBillViewModel(model);
            var output = new SqlParameter
            {

                DbType = DbType.Int32,
                Direction = ParameterDirection.Output
            };

            await _context.Database.ExecuteSqlCommandAsync(SPBill.cttnSP_Count_Bill_Pagination, output, model1.FromTime, model1.ToTime, model1.Status);
            var result = (int)output.Value;
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] BillViewModel model)
        {

            try
            {

                await _context.Database.ExecuteSqlCommandAsync(SPBill.cttnSP_Add_Bill, model.BillId, model.FullName, model.Email, model.Mobile, model.Address, model.Total);

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
        [HttpPut("update-status")]
        public async Task<IActionResult> UpdateBillStatus([FromBody] BillViewModel model)
        {
            if (await this.GetById(model.BillId) == null)
            {
                return NotFound(new ResponseResult(404));
            }

            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPBill.cttnSP_Update_Bill_Status, model.BillId, model.Status);
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
        public async Task<VBill> GetById(string id)
        {
            var result = await _context.Query<VBill>().AsNoTracking().FromSql(SPBill.cttnSP_Get_Bill_By_BillId, id).FirstOrDefaultAsync();
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
                var result = await _context.Database.ExecuteSqlCommandAsync(SPBill.cttnSP_Delete_Bill, id);
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
        //Tool
        private PaginationBillViewModel CheckPaginationBillViewModel(PaginationBillViewModel model)
        {

            if (model.Status == 0)
            {
                model.Status = null;
            }
            if (string.IsNullOrEmpty(model.FromTime) || string.IsNullOrEmpty(model.ToTime))
            {
                model.FromTime = null;
                model.ToTime = null;
            }


            return model;
        }
    }
}