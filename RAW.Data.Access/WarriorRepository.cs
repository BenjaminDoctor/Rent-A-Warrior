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
    public class WarriorRepository : IWarriorRepository
    {
        private Dictionary<string, IWarrior> ninjaRepo;

        public WarriorRepository()
        {
            ninjaRepo = new Dictionary<string, IWarrior>();
            ninjaRepo.Add("N001", new Warrior()
            {
                WarriorId = "N001",
                Name = "Bob",
                Rank = "Genin",
                Active = true
            });

            ninjaRepo.Add("J002", new Warrior()
            {
                WarriorId = "J001",
                Name = "Hinata",
                Rank = "Chunin",
                Active = true
            });

            ninjaRepo.Add("N002", new Warrior()
            {
                WarriorId = "N002",
                Name = "Ken",
                Rank = "Jonin",
                Active = false
            });
        }

        public async Task<IEnumerable<IWarrior>> GetWarriors()
        {
            return ninjaRepo.Values;
        }

        public async Task<IWarrior> GetWarrior(string ninjaId)
        {
            return ninjaRepo[ninjaId];
        }
    }
}
