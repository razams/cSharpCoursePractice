using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Imported_classes;
 
namespace ZaidimasKauliukai.Program_view
{
    class DiceSelectionMenu : Menu
    {
        int index = 3;
        TextLine textLine;

        public DiceSelectionMenu() : base(0, "", "", "")
        {
            textLine = new TextLine(10, 12, 100, $"Players will have {index} dice");
        }

        public override void Render()
        {
            base.Render();
            textLine.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void PlusDice()
        {
            if (index == 10)
            {
                return;
            }
            index++;
            textLine.ChangeData($"Players will have {index} dice");
            textLine.Render();
            Console.SetCursorPosition(0, 0);
        }

        public void MinusDice()
        {
            if (index == 3)
            {
                return;
            }
            index--;
            textLine.ChangeData($"Players will have {index} dice");
            textLine.Render();
            Console.SetCursorPosition(0, 0);
        }

        public int GetIndex()
        {
            return index;
        }
    }
}