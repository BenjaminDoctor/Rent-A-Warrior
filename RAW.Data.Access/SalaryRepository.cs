using RAW.Abstractions.Models;
using RAW.Abstractions.Repositories;
using RAW.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Data.Access
{
    public class SalaryRepository : ISalaryRepository
    {
        private Dictionary<string, ISalary> salaryRepo;

        public SalaryRepository()
        {
            salaryRepo = new Dictionary<string, ISalary>();

            salaryRepo.Add("N001", new Salary() { Rank = "Genin", SalaryRate = 100.00 });
            salaryRepo.Add("J002", new Salary() { Rank = "Chunin", SalaryRate = 200.00 });
            salaryRepo.Add("N002", new Salary() { Rank = "Jonin", SalaryRate = 300.00 });
        }

        public async Task<IEnumerable<ISalary>> GetSalaries()
        {
            return salaryRepo.Values;
        }

        public async Task<ISalary> GetSalary(string warriorId)
        {
            return salaryRepo[warriorId];
        }
    }
}
