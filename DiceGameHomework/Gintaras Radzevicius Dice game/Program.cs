using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Game_condition;
using ZaidimasKauliukai.Imported_classes;
using ZaidimasKauliukai.Program_view;

namespace ZaidimasKauliukai
{
    class Program
    {
        static void Main()
        {
            GameController gameController = new GameController();
            gameController.StartGame();
        }
    }
}
