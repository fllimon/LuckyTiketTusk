using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib.Interface;

namespace LuckyTiketLib
{
    public class LuckyTicketInitializer
    {
        public ILuckyTicket InitializeMoskowTicket()
        {
            return new MoskowLuckyTicket();
        }

        public ILuckyTicket InitializePiterTicket()
        {
            return new PiterLuckyTicket();
        }
    }
}
