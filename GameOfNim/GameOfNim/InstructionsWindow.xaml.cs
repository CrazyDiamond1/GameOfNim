using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameOfNim
{
    /// <summary>
    /// Interaction logic for Instructions.xaml
    /// </summary>
    public partial class Instructions : Window
    {
        private string instructions = "Nim is a game where two players remove objects from individual heaps." +
            "\nYou have to remove at least one object from a heap on your turn." +
            "\nYou may only remove objects from a single heap in a turn." +
            "\nYou cannot remove more objects from a heap than a heap contains." +
            "\nTurns alternate until a loser is decided. The loser is decided by whoever removes the last object on the board.";
        public Instructions()
        {
            InitializeComponent();
            InstructionsBox.Text = instructions;
        }

        /// <summary>
        /// When this method is called the instructions window will close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
