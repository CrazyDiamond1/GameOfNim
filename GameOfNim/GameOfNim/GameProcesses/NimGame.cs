using GameOfNim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.GameProcesses
{
    class NimGame
    {
        Player player1;
        Player player2;
        public Board gameBoard;
        int turnCounter;
        int difficulty;
        bool isPVP;
        public NimGame(int difficulty, bool isPVP)
        {
            gameBoard = new Board(difficulty);

            if (!isPVP)
            {
                player1 = new Player(true);
                player1.InitializePlayer();
                player2 = new Player(false);
            }
            else if (isPVP)
            {
                player1 = new Player(true);
                player1.InitializePlayer();
                player2 = new Player(false);
                player2.InitializePlayer();
            }
        }

        public void PlayerTurn()
        {

        }
        public void PlayerMove()
        {

        }
        public int CheckObjectTotal()
        {
            return 1;
        }
        public int CheckHeap()
        {
            return 1;
        }
    }
}
