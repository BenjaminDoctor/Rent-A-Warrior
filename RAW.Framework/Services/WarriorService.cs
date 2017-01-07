using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RAW.Framework.Models;
using RAW.Abstractions.Repositories;
using RAW.Abstractions.Models;
using RAW.Abstractions.Services;

namespace RAW.Framework.Services
{
    public class WarriorService : IWarriorService
    {
        IWarriorRepository warriorRepo;
        ISalaryRepository salaryRepo;

        public WarriorService(IWarriorRepository warriorRepo, ISalaryRepository salaryRepo)
        {
            if (warriorRepo == null) throw new ArgumentNullException(nameof(warriorRepo));
            if (salaryRepo == null) throw new ArgumentNullException(nameof(salaryRepo));

            this.warriorRepo = warriorRepo;
            this.salaryRepo = salaryRepo;
        }

        public async Task<IWarrior> GetWarrior(string id)
        {
            return await warriorRepo.GetWarrior(id);
        }

        public async Task<IEnumerable<IWarrior>> GetWarrior()
        {
            return await warriorRepo.GetWarriors();
        }

        public async Task<IWarriorSalary> GetWarriorWithSalary(string id)
        {
            var ninja = await warriorRepo.GetWarrior(id);
            var salary = await salaryRepo.GetSalary(id);

            return new WarriorSalary()
            {
                Name = ninja.Name,
                WarriorId = ninja.WarriorId,
                Rank = ninja.Rank,
                SalaryRate = salary.SalaryRate
            };
        }
    }
}
