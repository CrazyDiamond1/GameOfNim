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
        //Player player1;
        //Player player2;
        Board gameBoard;
        int turnCounter;
        int difficulty;
        bool isPVP;
        public NimGame(int difficulty, bool isPVP)
        {
            gameBoard = new Board(difficulty);

            if (!isPVP)
            {
                //player1 = new Player(true);
                //Player1.InitializePlayer();
                //player2 = new Player(false);
            }
        }
    }
}
