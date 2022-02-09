using SharedObject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
   public interface IKeyCodeRepository
    {
        // Đa kế thừa trong c#
        Task<int> GetByName(string name);
        Task<bool> UpdateByName(string name);
    }
}
