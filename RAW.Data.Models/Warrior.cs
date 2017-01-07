using RAW.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Data.Models
{
    public class Warrior : IWarrior
    {
        public string WarriorId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public bool Active { get; set; }
    }
}
