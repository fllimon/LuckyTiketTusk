using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib.Interface;
using LuckyTiketLib;

namespace LuckyTicketView
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(args[0]);
            int finishRange = int.Parse(args[1]);

            LuckyTicketInitializer ticket = new LuckyTicketInitializer();

            ILuckyTicket moskowLuckyTiket = ticket.InitializeMoskowTicket();
            ILuckyTicket piterLuckyTiket = ticket.InitializePiterTicket();

            Analyzer moskowTicketAnalyzer = new Analyzer(moskowLuckyTiket);
            Analyzer piterTicketAnalyzer = new Analyzer(piterLuckyTiket);

            moskowLuckyTiket.GetLuckyTicket(startRange, finishRange);
            Console.WriteLine($"Moskow Tickets: {moskowTicketAnalyzer.CountTicket}");

            Console.WriteLine();
            Console.WriteLine();

            piterLuckyTiket.GetLuckyTicket(startRange, finishRange);
            Console.WriteLine($"Piter Tickets: {piterTicketAnalyzer.CountTicket}");

            Console.ReadKey();
        }
    }
}
