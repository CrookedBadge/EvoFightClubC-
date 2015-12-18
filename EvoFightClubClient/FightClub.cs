using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EvoFightClubClient
{
    class FightClub
    {
        public List<Fighter> fighters { get; }
        private string log;

        public FightClub(ref string log)
        {
            this.log = log;
        }
        
    }
}
