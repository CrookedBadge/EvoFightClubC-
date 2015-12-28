using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoFightClub.Core
{
    public class FightClub
    {
        public List<HumanFighter> fighters { get; }
        private string log;

        public FightClub(ref string log)
        {
            this.log = log;
        }
        
    }
}
