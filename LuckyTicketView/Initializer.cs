using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib.Interface;

namespace LuckyTicketView
{
    class Initializer
    {
        public IAnalyzer InitializeAnalyzer(ILuckyTicket ticket)
        {
            return new Analyzer(ticket);
        }

        public IView InitializeView()
        {
            return new View();
        }
    }
}
