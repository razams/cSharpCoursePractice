using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Imported_classes;

namespace ZaidimasKauliukai.Program_view
{
    class PlayerSelectionMenu : Menu
    {
        private Button p2;
        private Button p3;
        private Button p4;
        private Button p5;
        private Button p6;
        private Button p7;

        public List<Button> buttons = new List<Button>();

        public PlayerSelectionMenu() : base(6, "", "Pasirinkite zaideju kieki", "")
        {
            p2 = new Button(50, 10, 5, 3, "2");
            p3 = new Button(60, 10, 5, 3, "3");
            p4 = new Button(50, 15, 5, 3, "4");
            p5 = new Button(60, 15, 5, 3, "5");
            p6 = new Button(50, 20, 5, 3, "6");
            p7 = new Button(60, 20, 5, 3, "7");

            p2.SetActive();

            buttons.Add(p2);
            buttons.Add(p3);
            buttons.Add(p4);
            buttons.Add(p5);
            buttons.Add(p6);
            buttons.Add(p7);
        }

        public override void Render()
        {
            base.Render();

            foreach (var item in buttons)
            {
                item.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public void MoveLeft()
        {
            buttons[activeButtonIndex].SetNotActive();
            buttons[activeButtonIndex].Render();
            MinusActiveButtonIndex();
            buttons[activeButtonIndex].SetActive();
            buttons[activeButtonIndex].Render();
        }

        public void MoveRight()
        {
            buttons[activeButtonIndex].SetNotActive();
            buttons[activeButtonIndex].Render();
            PlusActiveButtonIndex();
            buttons[activeButtonIndex].SetActive();
            buttons[activeButtonIndex].Render();

        }

        public void MoveUp()
        {
            buttons[activeButtonIndex].SetNotActive();
            buttons[activeButtonIndex].Render();
            UpActiveButtonIndex();
            buttons[activeButtonIndex].SetActive();
            buttons[activeButtonIndex].Render();

        }

        public void MoveDown()
        {
            buttons[activeButtonIndex].SetNotActive();
            buttons[activeButtonIndex].Render();
            DownActiveButtonIndex();
            buttons[activeButtonIndex].SetActive();
            buttons[activeButtonIndex].Render();

        }
    }
}