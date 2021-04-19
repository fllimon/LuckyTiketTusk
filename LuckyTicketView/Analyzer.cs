using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib;
using LuckyTiketLib.Interface;

namespace LuckyTicketView
{
    class Analyzer : IAnalyzer
    {
        #region =======------ PRIVATE DATA --------=======

        private int _countTickets = 0;
        private readonly ILuckyTicket _ticket;

        #endregion

        #region ======----- CTOR -----======

        public Analyzer(ILuckyTicket ticket)
        {
            _ticket = ticket;

            _ticket.LuckyTicketFounded += GetCountTicket;
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
