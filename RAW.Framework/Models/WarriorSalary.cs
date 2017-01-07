using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RAW.Abstractions.Models;

namespace RAW.Framework.Models
{
    public class WarriorSalary : IWarriorSalary
    {
        public string Name { get; set; }

        public string WarriorId { get; set; }

        public string Rank { get; set; }

        public double SalaryRate { get; set; }
    }
}
