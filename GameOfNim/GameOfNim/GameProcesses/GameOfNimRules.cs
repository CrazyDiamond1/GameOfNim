using GameOfNim.GameProcesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.GameProcesses
{
    public static class GameOfNimRules
    {
<<<<<<< HEAD:GameOfNim/GameOfNim/GameProcesses/GameOfNimRules.cs
        NimGame nim = new NimGame(1, true);
=======
        static NimGame nim = new NimGame(1, true);
>>>>>>> cf2561423cc8b4ae885f9f5201623dcbc2977dcb:GameOfNim/GameOfNim/GameProcesses/GameOfNimRules.cs

        /// <summary>
        /// When this method is called, it will validate the player's move
        /// </summary>
        /// <param name="heapNumber">An int representing which heap the object(s) is/are being removed from</param>
        /// <param name="objectsToBeRemoved">The amount of objects being removed from the chosen heap</param>
        /// <returns></returns>
        public static bool IsMoveLegal(int heapNumber, int objectsToBeRemoved)
        {
<<<<<<< HEAD:GameOfNim/GameOfNim/GameProcesses/GameOfNimRules.cs
            if (nim.CheckHeaps() > 0)
            {
                return true;
            }
=======
            //if (NimGame.CheckHeaps() > 0)
            //{
            //    return true;
            //}
>>>>>>> cf2561423cc8b4ae885f9f5201623dcbc2977dcb:GameOfNim/GameOfNim/GameProcesses/GameOfNimRules.cs
            return false;
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
