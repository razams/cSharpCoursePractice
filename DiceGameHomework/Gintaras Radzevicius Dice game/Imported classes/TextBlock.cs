using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasKauliukai.Imported_classes
{
    class TextBlock : GuiObject
    {
        private readonly List<TextLine> textBlock = new List<TextLine>();
        public void Render()
        {
            for (int i = 0; i < textBlock.Count; i++)
            {
                textBlock[i].Render();
            }
        }

        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlock.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }
    }
}
