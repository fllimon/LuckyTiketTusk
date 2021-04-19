using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicketView
{
    class DataValidator
    {
        public bool IsValidValue(int startRange, int finishRange)
        {
            bool isValid = true;

            if ((startRange < 0) || (finishRange > DefaultSettings.MAX_TICKET_RANGE))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
