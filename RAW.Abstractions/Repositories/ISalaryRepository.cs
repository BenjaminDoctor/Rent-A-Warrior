using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RAW.Abstractions.Models;

namespace RAW.Abstractions.Repositories
{
    public interface ISalaryRepository
    {
        Task<IEnumerable<ISalary>> GetSalaries();
        Task<ISalary> GetSalary(string ninjaId);
    }
}
