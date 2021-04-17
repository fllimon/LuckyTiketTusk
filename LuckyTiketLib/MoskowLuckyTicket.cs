using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuckyTiketLib.Interface;

namespace LuckyTiketLib
{
    class MoskowLuckyTicket : LuckyTicket
    {
        public override void GetLuckyTicket(int stratRange, int finishRange)
        {
            for (int i = stratRange; i < finishRange; i++)
            {
                string luckyTicket = string.Format($"{i}");
                int firstThreeNumbers = 0;
                int remeaningThreeNumbers = 0;

                var numbersList = luckyTicket.ToCharArray();

                for (int j = 0; j < numbersList.Length; j++)
                {
                    if (j < 3)
                    {
                        firstThreeNumbers += numbersList[j];
                    }
                    else
                    {
                        remeaningThreeNumbers += numbersList[j];
                    }
                }

                if (firstThreeNumbers == remeaningThreeNumbers)
                {
                    GetCountTicket(i);
                }
            }
        }
    }
}
