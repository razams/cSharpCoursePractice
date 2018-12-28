using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Imported_classes;

namespace ZaidimasKauliukai.Program_view
{
    class GameOverMenu : Menu
    {
        private Button replayButton;
        private Button goToMenutButton;
        private Button quitButton;
        public List<Button> gameOverButtons = new List<Button>();

        public GameOverMenu(string winner) : base(3, "", "", $"#################### Winner is {winner} ####################")
        {
            replayButton = new Button(20, 13, 18, 5, "R");
            replayButton.SetActive();

            goToMenutButton = new Button(50, 13, 18, 5, "H");
            quitButton = new Button(80, 13, 18, 5, "Q");

            gameOverButtons.Add(replayButton);
            gameOverButtons.Add(goToMenutButton);
            gameOverButtons.Add(quitButton);
        }

        public override void Render()
        {
            base.Render();
            replayButton.Render();
            goToMenutButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void MoveLeft()
        {
            gameOverButtons[activeButtonIndex].SetNotActive();
            gameOverButtons[activeButtonIndex].Render();
            MinusActiveButtonIndex();
            gameOverButtons[activeButtonIndex].SetActive();
            gameOverButtons[activeButtonIndex].Render();
        }

        public void MoveRight()
        {
            gameOverButtons[activeButtonIndex].SetNotActive();
            gameOverButtons[activeButtonIndex].Render();
            PlusActiveButtonIndex();
            gameOverButtons[activeButtonIndex].SetActive();
            gameOverButtons[activeButtonIndex].Render();

        }

    }
}
