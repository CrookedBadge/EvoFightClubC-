using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoFightClub.Core
{
    
    public class HumanFighter : Human, ICombatable 
    {
        public int strength { get; set; }
        public int speed { get; set; }
        public HumanFighter() : base()
        {
            
        }

        public int GetHP()
        {
            throw new NotImplementedException();
        }

        public CombatBlock GetBlock()
        {
            throw new NotImplementedException();
        }

    }
}
