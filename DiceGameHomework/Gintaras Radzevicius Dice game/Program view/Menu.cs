using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Imported_classes;

namespace ZaidimasKauliukai.Program_view
{
    class Menu : Window
    {
        private readonly int buttonQuantity;
        private TextBlock titleTextBlock;

        public int activeButtonIndex = 0;

        public Menu(int buttonQuantity, string titleRow1, string titleRow2, string titleRow3) : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { titleRow1, titleRow2, titleRow3 });
            this.buttonQuantity = buttonQuantity;
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();
            Console.SetCursorPosition(0, 0);
        }

        public int GetActiveButtonIndex()
        {
            return activeButtonIndex;
        }

        public void PlusActiveButtonIndex()
        {
            if (activeButtonIndex == buttonQuantity - 1)
            {
                activeButtonIndex = 0;
                return;
            }
            activeButtonIndex++;
        }

        public void MinusActiveButtonIndex()
        {
            if (activeButtonIndex == 0)
            {
                activeButtonIndex = buttonQuantity - 1;
                return;
            }
            activeButtonIndex--;
        }

        public void UpActiveButtonIndex()
        {
            switch (activeButtonIndex)
            {
                case 0:
                    activeButtonIndex = 4;
                    break;

                case 1:
                    activeButtonIndex = 5;
                    break;

                case 2:
                    activeButtonIndex = 0;
                    break;

                case 3:
                    activeButtonIndex = 1;
                    break;
                case 4:
                    activeButtonIndex = 2;
                    break;
                case 5:
                    activeButtonIndex = 3;
                    break;
            }
        }

        public void DownActiveButtonIndex()
        {
            switch (activeButtonIndex)
            {
                case 0:
                    activeButtonIndex = 2;
                    break;

                case 1:
                    activeButtonIndex = 3;
                    break;

                case 2:
                    activeButtonIndex = 4;
                    break;

                case 3:
                    activeButtonIndex = 5;
                    break;
                case 4:
                    activeButtonIndex = 0;
                    break;
                case 5:
                    activeButtonIndex = 1;
                    break;
            }
        }
    }
}
