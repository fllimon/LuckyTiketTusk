using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTiketLib.Interface
{
    public interface ILuckyTicket
    {
        void GetLuckyTicket(int startRange, int finishRange);

        event LuckyTicketFound LuckyTicketFounded;
    }
}
