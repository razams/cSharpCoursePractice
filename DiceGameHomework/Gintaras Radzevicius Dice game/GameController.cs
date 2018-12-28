using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidimasKauliukai.Game_condition;

namespace ZaidimasKauliukai
{
    class GameController
    {
        int playersQuantity = 0;
        int dicesQuantity = 0;
        List<Player> playersList = new List<Player>();

        int counter = 0;
        bool exitLoop = false;
        bool exitGame = false;
        bool showMenu = true;

        List<int> resultList = new List<int>();
        int result = 0;
        int winner = 0;
        string winnerName;
        public void StartGame()
        {
            MenuController menuController = new MenuController();

            menuController.StartMainMenu();

            if (menuController.ExitGame())
            {
                exitGame = true;
                return;
            }

            while (exitGame != true)
            {

                counter = 0;
                exitLoop = false;
                exitGame = false;
                resultList.Clear();
                result = 0;
                winner = 0;


                if (showMenu)
                {
                    playersQuantity = 0;
                    dicesQuantity = 0;
                    playersList.Clear();

                    menuController.StartPlayerSelectionMenu();
                    menuController.StartDiceSelectionMenu();

                    playersQuantity = menuController.GetPlayersQuantity();
                    dicesQuantity = menuController.GetDicesQuantity();

                    for (int i = 0; i < playersQuantity; i++)
                    {
                        playersList.Add(new Player("Player" + (i + 1), dicesQuantity));
                    }
                }

                while (exitLoop != true)
                {
                    Console.Clear();
                    counter = 1;
                    foreach (var item in playersList)
                    {
                        result = item.PlayerThrowsDices();
                        resultList.Add(result);
                        Console.WriteLine("Player " + counter + " throws dices. Result: " + result);
                        counter++;
                    }

                    Console.WriteLine();
                    result = 0;

                    for (int i = 0; i < resultList.Count; i++)
                    {
                        if (resultList[i] > result)
                        {
                            result = resultList[i];
                            winner = i;
                        }

                    }

                    exitLoop = true;

                    for (int i = 0; i < resultList.Count; i++)
                    {
                        if (i == winner)
                        {
                            continue;
                        }

                        if (resultList[i] == result)
                        {
                            Console.WriteLine("################## same result exists ##################");
                            exitLoop = false;
                            break;
                        }
                    }
                    resultList.Clear();
                    System.Threading.Thread.Sleep(1000);

                }

                winnerName = playersList[winner].GetPlayerName();
                menuController.StartGameOverMenu(winnerName);

                if (menuController.ExitGame())
                {
                    exitGame = true;
                    return;
                }

                switch (menuController.GetUserChoice())
                {
                    case 0:
                        showMenu = false;
                        break;
                    case 1:
                        showMenu = true;
                        break;
                    case 2:
                        exitGame = true;
                        break;
                }
            }
        }
    }
}
