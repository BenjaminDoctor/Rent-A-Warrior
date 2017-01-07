using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RAW.Abstractions.Models;

namespace RAW.Abstractions.Repositories
{
    public interface IWarriorRepository : IRepository
    {
        Task<IEnumerable<IWarrior>> GetWarriors();
        Task<IWarrior> GetWarrior(string warriorId);
    }
}
