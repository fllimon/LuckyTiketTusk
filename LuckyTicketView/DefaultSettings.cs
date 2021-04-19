using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicketView
{
    class DefaultSettings
    {
        public const string DEFAULT_FILE_PATH = @".\file.txt";
        public const int MAX_TICKET_RANGE = 999999;
        public const string INSTRUCTION = "1. Specify the path to the text file\n" +
                                              "2. In file condition must be <Moskow> or <Piter>.";
    }
}
