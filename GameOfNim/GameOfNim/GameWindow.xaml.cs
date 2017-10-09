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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        TextBox removeBoxZero = new TextBox();
        TextBox removeBoxOne = new TextBox();
        TextBox removeBoxTwo = new TextBox();
        TextBox removeBoxThree = new TextBox();
        //private NimGame currentGame;
        public GameWindow(int difficulty, bool isPVP)
        {
            InitializeComponent();
            if(difficulty == 1)
            {
                for(int i = 0; i < 2; i++)
                {
                    StackPanel stack = new StackPanel();
                    Button removeButton = new Button();
                    removeButton.Content = "R E M O V E";
                    if(i == 0)
                    {
                        removeButton.Click += RemoveButtonZero_Click;
                        stack.Children.Add(removeBoxZero);
                    }
                    else
                    {
                        removeButton.Click += RemoveButtonOne_Click;
                        stack.Children.Add(removeBoxOne);
                    }
                    stack.Children.Add(removeButton);
                    GameBoard.Children.Add(stack);
                    Grid.SetRow(stack, 1);
                    Grid.SetColumn(stack, i);
                }
            }
            else if (difficulty == 2)
            {
                GameBoard.ColumnDefinitions.Add(new ColumnDefinition());
                for (int i = 0; i < 3; i++)
                {
                    StackPanel stack = new StackPanel();
                    Button removeButton = new Button();
                    removeButton.Content = "R E M O V E";
                    if (i == 0)
                    {
                        removeButton.Click += RemoveButtonZero_Click;
                        stack.Children.Add(removeBoxZero);
                    }
                    else if(i == 1)
                    {
                        removeButton.Click += RemoveButtonOne_Click;
                        stack.Children.Add(removeBoxOne);
                    }
                    else
                    {
                        removeButton.Click += RemoveButtonTwo_Click;
                        stack.Children.Add(removeBoxTwo);
                    }
                    stack.Children.Add(removeButton);
                    GameBoard.Children.Add(stack);
                    Grid.SetRow(stack, 1);
                    Grid.SetColumn(stack, i);
                }
            }
            else
            {
                GameBoard.ColumnDefinitions.Add(new ColumnDefinition());
                GameBoard.ColumnDefinitions.Add(new ColumnDefinition());
                for (int i = 0; i < 4; i++)
                {
                    StackPanel stack = new StackPanel();
                    Button removeButton = new Button();
                    removeButton.Content = "R E M O V E";
                    if (i == 0)
                    {
                        removeButton.Click += RemoveButtonZero_Click;
                        stack.Children.Add(removeBoxZero);
                    }
                    else if (i == 1)
                    {
                        removeButton.Click += RemoveButtonOne_Click;
                        stack.Children.Add(removeBoxOne);
                    }
                    else if (i == 2)
                    {
                        removeButton.Click += RemoveButtonTwo_Click;
                        stack.Children.Add(removeBoxTwo);
                    }
                    else
                    {
                        removeButton.Click += RemoveButtonThree_Click;
                        stack.Children.Add(removeBoxThree);
                    }
                    stack.Children.Add(removeButton);
                    GameBoard.Children.Add(stack);
                    Grid.SetRow(stack, 1);
                    Grid.SetColumn(stack, i);
                }
            }
        }

        private void RemoveButtonZero_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void RemoveButtonOne_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void RemoveButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void RemoveButtonThree_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            Instructions instructionsWindow = new Instructions();
            instructionsWindow.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
