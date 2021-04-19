using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicketView
{
    interface IView
    {
        void PrintInstructions();

        void PrintResult(IAnalyzer result);
    }
}
