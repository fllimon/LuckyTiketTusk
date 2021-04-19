using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicketView
{
    class DataConvertor
    {
        public static int ConvertNumber(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
