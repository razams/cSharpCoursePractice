using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Imported_classes;

namespace ZaidimasKauliukai.Program_view

{
    class MainMenu : Menu
    {
        private Button playButton;
        private Button quitButton;

        public List<Button> menuButtons = new List<Button>();

        public MainMenu() : base(2, "Kauliuku zaidimas", "Made by Gintaras Radzevicius", "Made in Vilnius Coding School!")
        {
            playButton = new Button(35, 13, 18, 5, "P");
            playButton.SetActive();

            quitButton = new Button(65, 13, 18, 5, "Q");

            menuButtons.Add(playButton);
            menuButtons.Add(quitButton);
        }

        public override void Render()
        {
            base.Render();
            playButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void MoveLeft()
        {
            menuButtons[activeButtonIndex].SetNotActive();
            menuButtons[activeButtonIndex].Render();
            MinusActiveButtonIndex();
            menuButtons[activeButtonIndex].SetActive();
            menuButtons[activeButtonIndex].Render();
        }

        public void MoveRight()
        {
            menuButtons[activeButtonIndex].SetNotActive();
            menuButtons[activeButtonIndex].Render();
            PlusActiveButtonIndex();
            menuButtons[activeButtonIndex].SetActive();
            menuButtons[activeButtonIndex].Render();

        }

    }
}