using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LuckyTiketLib;

namespace LuckyTicketView
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(args[0]);
            int finishRange = int.Parse(args[1]);

            LuckyTicket moskowLuckyTicket = new MoskowLuckyTicket();
            LuckyTicket piterLuckyTicket = new MoskowLuckyTicket();
            Analyzer moskowTicketAnalyzer = new Analyzer(moskowLuckyTicket);
            Analyzer piterTicketAnalyzer = new Analyzer(piterLuckyTicket);

            moskowLuckyTicket.GetLuckyTicket(startRange, finishRange);
            Console.WriteLine($"Moskow Tickets: {moskowTicketAnalyzer.CountTicket}");

            Console.WriteLine();
            Console.WriteLine();

            piterLuckyTicket.GetLuckyTicket(startRange, finishRange);
            Console.WriteLine($"Piter Tickets: {piterTicketAnalyzer.CountTicket}");

            Console.ReadKey();
        }
    }
}
