using RAW.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Data.Models
{
    public class Salary : ISalary
    {
        public string Rank { get; set; }
        public double SalaryRate { get; set; }
    }
}
