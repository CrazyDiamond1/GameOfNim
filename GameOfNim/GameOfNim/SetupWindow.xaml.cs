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
            PVP.IsChecked = true;
            Easy.IsChecked = true;
        }

        public void PVP_Checked()
        {
            if (PVP.IsChecked == true)
            {
                isPVP = true;
            }
        }
        public void PVC_Checked()
        {
            if (PVC.IsChecked == true)
            {
                isPVP = false;
            }
        }
        public void Easy_Checked()
        {
            if (Easy.IsChecked == true)
            {
                difficulty = 1;
            }
        }
        public void Medium_Checked()
        {
            if (Medium.IsChecked == true)
            {
                difficulty = 2;
            }
        }
        public void Hard_Checked()
        {
            if (Hard.IsChecked == true)
            {
                difficulty = 3;
            }
        }

        /// <summary>
        /// When this method is called, a window containing the game will present itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PVP_Checked();
            PVC_Checked();
            Easy_Checked();
            Medium_Checked();
            Hard_Checked();
            GameWindow game = new GameWindow(difficulty, isPVP);
            this.Close();
            game.ShowDialog();
        }
    }
}
