using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Abstractions.Models
{
    public interface ISalary
    {
        string Rank { get; set; }
        double SalaryRate { get; set; }
    }
}
