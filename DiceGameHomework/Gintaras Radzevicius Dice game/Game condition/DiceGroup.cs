using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Game_condition
{
    class DiceGroup : Dice
    {
        Dice[] dices;

        public DiceGroup(int dicesQuantity) : base()
        {
            dices = new Dice[dicesQuantity];
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice();
            }
        }

        public Array GetDicesArray()
        {
            return dices;
        }

        public int ThrowDiceGroupAndGetValue()
        {
            int sum = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                sum =  sum + dices[i].ThrowDiceAndGetValue();
            }
            return sum;
        }
    }
}
