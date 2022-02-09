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
    public class BillDetailController : ControllerBase
    {
        private readonly CTTNDbContext _context;

        public BillDetailController(CTTNDbContext context)
        {
            _context = context;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] List<BillDetailViewModel> model)
        {
            try
            {
                foreach (var item in model)
                {
                    await _context.Database.ExecuteSqlCommandAsync(SPBillDetail.cttnSP_Add_BillDetail,  item.ProductName, item.Price, item.Quantity, item.TotalMoney, item.BillId);
                }
                
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
        [HttpGet("get-by-bill/{id}")]
        public async Task<List<VBillDetail>> GetByBillId(string id)
        {
            var result = await _context.Query<VBillDetail>().AsNoTracking().FromSql(SPBillDetail.cttnSP_Get_BillDetail_By_BillId, id).ToListAsync();
            return result;
        }

    }
}