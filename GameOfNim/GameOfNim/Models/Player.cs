using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameOfNim.Models
{
    public class Player
    {
        public bool isHuman;
        public string Name { get;  private set; }


        public Player(bool isHuman)
        {
            this.isHuman = isHuman;
        }

        public void InitializePlayer()
        {
            if(isHuman == false)
            {
                Name = "Computer";
            }
            else
            {
                Name = Microsoft.VisualBasic.Interaction.InputBox("Enter a player name", "Name Input");
            }
        }
    }
}
