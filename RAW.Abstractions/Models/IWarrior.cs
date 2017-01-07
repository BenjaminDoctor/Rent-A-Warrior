using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Abstractions.Models
{
    public interface IWarrior
    {
        string WarriorId { get; set; }
        string Name { get; set; }
        string Rank { get; set; }
    }
}
