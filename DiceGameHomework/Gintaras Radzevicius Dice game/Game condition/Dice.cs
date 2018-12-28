using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Game_condition
{
    class Dice
    {
        const int minValue = 1;
        const int maxValue = 6;
        public int ThrowDiceAndGetValue()
        {
            int value = 0;
            Random random = new Random();
            System.Threading.Thread.Sleep(50);
            value = random.Next(minValue, maxValue);
            return value;
        }
    }
}
