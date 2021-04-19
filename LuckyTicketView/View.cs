using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicketView
{
    class View : IView
    {
        public void PrintInstructions()
        {
            Console.WriteLine(DefaultSettings.INSTRUCTION);
        }

        public void PrintResult(IAnalyzer result)
        {
            Console.WriteLine($"Total lucky tickets in the range: {result.CountTicket}");
        }
    }
}
