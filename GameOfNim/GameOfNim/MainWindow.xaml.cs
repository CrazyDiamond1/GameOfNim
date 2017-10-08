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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfNim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When this method is called by clicking the play button the setup window for the game opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            SetupWindow setupWindow = new SetupWindow();
            setupWindow.ShowDialog();
        }

        /// <summary>
        /// When this method is called by clicking the instructions button the instructions window containing the rules for play opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            Instructions instructionsWindow = new Instructions();
            instructionsWindow.ShowDialog();
        }

        /// <summary>
        /// When this method is called by clicking the exit button the game closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
