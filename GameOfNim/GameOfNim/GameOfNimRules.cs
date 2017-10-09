using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    public class GameOfNimRules
    {
        //NimGame nim = new NimGame(1, true);

        /// <summary>
        /// When this method is called, it will validate the player's move
        /// </summary>
        /// <returns></returns>
        public bool IsMoveLegal()
        {
            //if (nim.CheckHeaps() > 0)
            //{
            //    return true;
            //}
            return false;
        }

        /// <summary>
        /// When this method is called, it will determine if a player has lost yet.
        /// </summary>
        /// <param name="objectsTotal"></param>
        /// <returns></returns>
        public bool PlayerLoses(int objectsTotal)
        {
            if (objectsTotal <= 1)
            {
                return true;
            }
            return false;
        }
    }
}
