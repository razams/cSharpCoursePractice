using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Program_view;

namespace ZaidimasKauliukai
{
    class MenuController
    {
        bool exitGame = false;
        bool exitLoop = false;

        int activeButtonIndex;

        ConsoleKeyInfo pressedChar;

        MainMenu mainMenu = new MainMenu();
        PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
        DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu();
        GameOverMenu gameOverMenu;

        public void StartMainMenu()
        {
            mainMenu.Render();

            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.LeftArrow:
                        mainMenu.MoveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        mainMenu.MoveRight();
                        break;

                    case ConsoleKey.Enter:
                        exitLoop = true;
                        if(mainMenu.GetActiveButtonIndex() == 1)
                        {
                            exitGame = true;
                        }
                        break;

                    case ConsoleKey.Escape:
                        exitGame = true;
                        exitLoop = true;
                        break;
                }

            } while (exitLoop != true);
        }

        public void StartPlayerSelectionMenu()
        {
            switch (mainMenu.GetActiveButtonIndex())
            {
                case 0: //playButton pressed
                    playerSelectionMenu.Render();
                    exitLoop = false;

                    do
                    {
                        pressedChar = Console.ReadKey(true);
                        switch (pressedChar.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                playerSelectionMenu.MoveLeft();
                                break;

                            case ConsoleKey.RightArrow:
                                playerSelectionMenu.MoveRight();
                                break;

                            case ConsoleKey.DownArrow:
                                playerSelectionMenu.MoveDown();
                                break;

                            case ConsoleKey.UpArrow:
                                playerSelectionMenu.MoveUp();
                                break;

                            case ConsoleKey.Enter:
                                exitLoop = true;
                                break;

                        }

                    } while (exitLoop != true);

                    break;

                case 1: //quitButton pressed
                    exitGame = true;
                    break;
            }
        }

        public void StartDiceSelectionMenu()
        {
            diceSelectionMenu.Render();
            exitLoop = false;

            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Subtract:
                        diceSelectionMenu.MinusDice();
                        break;

                    case ConsoleKey.Add:
                        diceSelectionMenu.PlusDice();
                        break;

                    case ConsoleKey.Enter:
                        exitLoop = true;
                        break;
                }

            } while (exitLoop != true);
        }



        public void StartGameOverMenu(string winner)
        {
            gameOverMenu = new GameOverMenu(winner);
            gameOverMenu.Render();
            exitLoop = false;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.LeftArrow:
                        gameOverMenu.MoveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        gameOverMenu.MoveRight();
                        break;

                    case ConsoleKey.Enter:
                        activeButtonIndex = gameOverMenu.GetActiveButtonIndex();
                        exitLoop = true;
                        break;

                    case ConsoleKey.Escape:
                        activeButtonIndex = gameOverMenu.GetActiveButtonIndex();
                        exitGame = true;
                        exitLoop = true;
                        break;
                }

            } while (exitLoop != true);
        }


        public int GetDicesQuantity()
        {
            return diceSelectionMenu.GetIndex();
        }

        public int GetPlayersQuantity()
        {

            return playerSelectionMenu.GetActiveButtonIndex() + 2;
        }

        public bool ExitGame()
        {
            return exitGame;
        }

        public int GetUserChoice()
        {
            return activeButtonIndex;
        }

    }
}