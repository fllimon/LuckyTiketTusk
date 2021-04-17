using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib.Interface;

namespace LuckyTiketLib
{
    abstract class LuckyTicket : ILuckyTicket
    {
        protected LuckyTicketFound _luckyTicketFounded;
        
        public event LuckyTicketFound LuckyTicketFounded
        {
            add
            {
                _luckyTicketFounded += value;
            }
            remove
            {
                _luckyTicketFounded -= value;
            }
        }

        public abstract void GetLuckyTicket(int stratRange, int finishRange);

        protected void GetCountTicket(int ticket)
        {
            if (_luckyTicketFounded != null)
            {
                _luckyTicketFounded(this, new CountTicketEventArgs(ticket));
            }        
        }
    }
}
