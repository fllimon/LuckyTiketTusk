using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib;

namespace LuckyTicketView
{
    class Analyzer
    {
        #region =======------ PRIVATE DATA --------=======

        private int _countTickets = 0;
        private readonly LuckyTicket _ticket;

        #endregion

        #region ======----- CTOR -----======

        public Analyzer(LuckyTicket ticket)
        {
            _ticket = ticket;

            _ticket.CountLuckyTicket += GetCountTicket;
        }

        #endregion

        #region =======------ PROPERTIES -------======

        public int CountTicket
        {
            get
            {
                return _countTickets;
            }
        }

        #endregion

        private void GetCountTicket(object sender, CountTicketEventArgs args)
        {
            _countTickets++;
        }
    }
}
