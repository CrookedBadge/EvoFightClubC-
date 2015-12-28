using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoFightClubClient
{
    interface ICombatable
    {
        int GetHP();
        CombatBlock GetBlock();
    }
}
