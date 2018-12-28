using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Game_condition
{
    class Player
    {
        string playerName;
        DiceGroup diceGroup;
        public Player(string name, int dicesQuantity)
        {
            playerName = name;
            diceGroup = new DiceGroup(dicesQuantity);
        }
        public int PlayerThrowsDices()
        {
            return diceGroup.ThrowDiceGroupAndGetValue();
        }

        public string GetPlayerName()
        {
            return playerName;
        }
    }
}
