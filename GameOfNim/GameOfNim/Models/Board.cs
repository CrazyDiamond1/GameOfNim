using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    class Board
    {
        public int[] heaps;
        public int numOfHeaps;
        public int objectTotal;

        /// <summary>
        /// Creates the gameboard according to the difficulty selected.
        /// </summary>
        /// <param name="difficulty">an int representing the difficulty</param>
        public Board(int difficulty)
        {
            if(difficulty == 1)
            {
                heaps = new int[2];
                heaps[0] = 2;
                heaps[1] = 2;
                numOfHeaps = 2;
                objectTotal = 4;
            }
            else if(difficulty == 2)
            {
                heaps = new int[3];
                heaps[0] = 7;
                heaps[1] = 5;
                heaps[2] = 2;
                numOfHeaps = 3;
                objectTotal = 14;
            }
            else if(difficulty == 3)
            {
                heaps = new int[4];
                heaps[0] = 9;
                heaps[1] = 8;
                heaps[2] = 3;
                heaps[3] = 2;
                numOfHeaps = 4;
                objectTotal = 22;
            }

        }
    }
}
