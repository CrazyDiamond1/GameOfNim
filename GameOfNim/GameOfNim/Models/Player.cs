using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    public class Player
    {
        public bool isHuman;
        public string Name { get; private set; }


        public Player(bool isHuman)
        {
            this.isHuman = isHuman;
        }

        public void InitializePlayer()
        {
            
        }
    }
}
