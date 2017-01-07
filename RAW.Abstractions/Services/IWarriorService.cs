using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RAW.Abstractions.Models;

namespace RAW.Abstractions.Services
{
    public interface IWarriorService
    {
        Task<IEnumerable<IWarrior>> GetWarrior();
        Task<IWarrior> GetWarrior(string id);
        Task<IWarriorSalary> GetWarriorWithSalary(string id);
    }
}
