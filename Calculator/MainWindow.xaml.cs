/// Chapter No. 60		Exercise No. Lab
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  October 10, 2021
///
/// Problem Statement: Create a simple calculator that takes advantage of
///                    try-catch blocks for user input.
///
/// Overall Plan:
/// 1)  Create two doubles for the left and right inputs.
/// 2)  Create a string to hold the symbol of the selected item from the
///     listbox.
/// 3)  Try to parse the left and right input boxes as doubles to store
///     into their respective doubles.
/// 4)  Throw a format error if the input values are not numbers.
/// 5)  Store the selected item from the listbox in the char.
/// 6)  Create a double called answer.
/// 7)  Switch through each possible case of the Listbox, defaulting on
///     addition.
/// 8)  In case of Subtraction, subtract the right value from the left
///     value and store the difference in answer.
/// 9)  In case of Multiplication, find the product of the two values and
///     store it in answer.
/// 10) In case of Division, divide the left input by the right input and
///     store the value in answer.
/// 11) In case of Modular Division, find the quotient same as division,
///     storing the remainder rather than the quotient in answer.
/// 12) In case of default, find the sum of the left and right value and
///     store it in answer.
/// 13) Display answer.

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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double l_num = 0, r_num = 0, answer = 0;
            string operation = Operators.SelectedItem.ToString();
            try
            {
                l_num = double.Parse(LNum.Text);
                r_num = double.Parse(RNum.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please input a number for the left and right values.");
            }
            catch
            {
                MessageBox.Show("An unknown error has ocurred.");
            }

            if (operation.Contains("+"))
            {
                answer = l_num + r_num;
            }
            else if (operation.Contains("-"))
            {
                answer = l_num - r_num;
            }
            else if (operation.Contains("*"))
            {
                answer = l_num * r_num;
            }
            else if (operation.Contains("/"))
            {
                answer = l_num / r_num;
            }
            else
            {
                answer = l_num % r_num;
            }

            Answer.Content = "= " + answer.ToString();
        }
    }
}
