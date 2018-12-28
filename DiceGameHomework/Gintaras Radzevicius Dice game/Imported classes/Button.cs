using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Imported_classes
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;
        private bool isActive = false;

        public Button (int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');
            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }
        public void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
            Console.SetCursorPosition(0, 0);
        }
        public void SetActive()
        {
            isActive = true;
        }
        public void SetNotActive()
        {
            isActive = false;
        }
    }
}