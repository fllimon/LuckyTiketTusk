using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTiketLib
{
    public class CountTicketEventArgs : EventArgs
    {
        public int NumberLuckyTicket { get; private set; }

        public CountTicketEventArgs(int ticketNumber)
        {
            NumberLuckyTicket = ticketNumber;
        }
    }
}
