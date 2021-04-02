using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTiketLib
{
    public abstract class LuckyTicket
    {
        protected LuckyTicketsCounter _countLuckyTicket;
        private int _countTicket = 0;

        public event LuckyTicketsCounter CountLuckyTicket
        {
            add
            {
                _countLuckyTicket += value;
            }
            remove
            {
                _countLuckyTicket -= value;
            }
        }

        public abstract void GetLuckyTicket(int stratRange, int finishRange);

        protected void GetCountTicket(int ticket)
        {
            if (_countLuckyTicket != null)
            {
                _countLuckyTicket(this, new CountTicketEventArgs(ticket));
            }        
        }
    }
}
