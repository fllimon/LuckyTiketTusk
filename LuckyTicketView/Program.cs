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
            try
            {
                int startRange = DataConvertor.ConvertNumber(args[0]);
                int finishRange = DataConvertor.ConvertNumber(args[1]);

                DataValidator validator = new DataValidator();
                View ui = new View();

                bool result = validator.IsValidValue(startRange, finishRange);

                if (result)
                {
                    string filePath = ui.GetFilePath();

                    ConsoleController _startApp = new ConsoleController(startRange, finishRange);
                    _startApp.Run();
                }
                else
                {
                    ui.PrintInstructions();

                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
