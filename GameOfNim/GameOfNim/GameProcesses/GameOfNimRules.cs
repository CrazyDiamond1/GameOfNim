using GameOfNim.GameProcesses;
using GameOfNim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.GameProcesses
{
    public static class GameOfNimRules
    {
        //static NimGame nim = new NimGame(1, true);

        /// <summary>
        /// When this method is called, it will validate the player's move
        /// </summary>
        /// <param name="heapNumber">An int representing which heap the object(s) is/are being removed from</param>
        /// <param name="objectsToBeRemoved">The amount of objects being removed from the chosen heap</param>
        /// <returns></returns>
        public static bool IsMoveLegal(int heapNumber, int objectsToBeRemoved, Board board)
        {
            if(objectsToBeRemoved == 0)
            {
                return false;
            }
            if(board.heaps[heapNumber] < objectsToBeRemoved)
            {
                return false;
            }
            if(board.heaps[heapNumber] <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// When this method is called, it will determine if a player has lost yet.
        /// </summary>
        /// <param name="objectsTotal"></param>
        /// <returns></returns>
        public static bool PlayerLoses(int objectsTotal)
        {
            if (objectsTotal < 1)
            {
                return true;
            }
            return false;
        }
    }
}
