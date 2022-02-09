using WebAPI.Models;
using WebAPI.StoreProcedured;
using Microsoft.EntityFrameworkCore;
using SharedObject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public class KeyCodeRepository : IKeyCodeRepository
    {
        private readonly CTTNDbContext _context;
        public KeyCodeRepository(CTTNDbContext context)
        {
            _context = context;
        }
        public async Task<int> GetByName(string name)
        {
            var result = await _context.Query<VKeyCode>().AsNoTracking().FromSql(SPKeyCode.SP_Get_KeyCode_By_Name, name).FirstOrDefaultAsync();
            return result.Number;
        }

        public async Task<bool> UpdateByName(string name)
        {
            try
            {
                await _context.Database.ExecuteSqlCommandAsync(SPKeyCode.SP_Update_KeyCode_By_Name, name);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
