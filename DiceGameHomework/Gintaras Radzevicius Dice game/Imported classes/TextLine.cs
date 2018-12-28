using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Imported_classes
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 0)
        {
            this.data = data;
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            if (width > data.Length)
            {
                int offset = (width - data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.Write(data);
        }

        public void ChangeData(string dataNew)
        {
            data = dataNew;
        }
    }
}
