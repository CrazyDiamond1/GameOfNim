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
    /// Interaction logic for SetupWindow.xaml
    /// </summary>
    public partial class SetupWindow : Window
    {
        public bool isPVP;
        public int difficulty;
        public SetupWindow()
        {
            InitializeComponent();
        }

        public void PVP_Checked()
        {
            isPVP = true;
        }
        public void PVC_Checked()
        {
            isPVP = false;
        }
        public void Easy_Checked()
        {
            difficulty = 1;
        }
        public void Medium_Checked()
        {
            difficulty = 2;
        }
        public void _Checked()
        {
            difficulty = 3;
        }

        /// <summary>
        /// When this method is called, a window containing the game will present itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
