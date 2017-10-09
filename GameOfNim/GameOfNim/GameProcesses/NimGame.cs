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
<<<<<<< HEAD
        public Player player1;
        public Player player2;
        public Board gameBoard;
        int turnCounter = 0;
=======
        Player player1;
        Player player2;
        public Board gameBoard;
        int turnCounter;
>>>>>>> 2739afb455a9bd09d31fa1ae6f4eea1839e21f0c
        int difficulty;
        bool isPVP;
        Random randold = new Random();
        public NimGame(int difficulty, bool isPVP)
        {
            gameBoard = new Board(difficulty);

            if (!isPVP)
            {
                isPVP = false;
                player1 = new Player(true);
                player1.InitializePlayer();
                player2 = new Player(false);
            }
            else if (isPVP)
            {
                isPVP = true;
                player1 = new Player(true);
                player1.InitializePlayer();
                player2 = new Player(false);
                player2.InitializePlayer();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void PlayerTurn()
        {
            turnCounter =+ 1;
            CompPlayerMove();
        }
        public void CompPlayerMove()
        {
            turnCounter =+ 1;
            int numOfHeaps = gameBoard.numOfHeaps;
            int heapToRemove = randold.Next(0,numOfHeaps);
            int objectsInHeap = gameBoard.heaps[heapToRemove];
            int objectsToRemove = randold.Next(1,objectsInHeap + 1);
            gameBoard.heaps[heapToRemove] =- objectsToRemove;
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
