using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTiketLib
{
    class MoskowLuckyTicket : LuckyTicket
    {
        public override void GetLuckyTicket(int stratRange, int finishRange)
        {
            for (int i = stratRange; i < finishRange; i++)
            {
                string luckyTicket = string.Format($"{i}");

                int firstThreeNumbers = (int)luckyTicket[0] + (int)luckyTicket[1] + (int)luckyTicket[2];
                int remeaningThreeNumbers = (int)luckyTicket[3] + (int)luckyTicket[4] + (int)luckyTicket[5];

                if (firstThreeNumbers == remeaningThreeNumbers)
                {
                    GetCountTicket(i);
                }
            }
        }
    }
}
