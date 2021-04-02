using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTiketLib
{
    public abstract class LuckyTicket
    {
        public abstract void GetLuckyTicket(int stratRange, int finishRange);
    }
}
