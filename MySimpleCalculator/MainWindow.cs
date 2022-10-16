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

namespace MySimpleCalculator
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

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "1";
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "2";
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "3";
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "4";
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "5";
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "6";
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "7";
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "8";

        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "9";
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += "0";
        }

        private void ButtonFloatingPoint_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperand.Text += ".";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            PrevOperand.Text = CurrentOperand.Text;
            CurrentOperand.Text = "";
            Operand.Text = "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            PrevOperand.Text = CurrentOperand.Text;
            CurrentOperand.Text = "";
            Operand.Text = "-";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            PrevOperand.Text = CurrentOperand.Text;
            CurrentOperand.Text = "";
            Operand.Text = "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            PrevOperand.Text = CurrentOperand.Text;
            CurrentOperand.Text = "";
            Operand.Text = "";
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            double rightOperand = double.Parse(CurrentOperand.Text);
            double leftOperand = double.Parse(PrevOperand.Text);
            string op = Operand.Text;

            double result = 0.00;
            if (op == "+")
            {
                result = leftOperand + rightOperand;
            }
            else if (op == "-")
            {
                result = leftOperand - rightOperand;
            }
            else if (op == "*")
            {
                result = leftOperand * rightOperand;
            }
            else if (op == "÷")
            {
                result = leftOperand / rightOperand;
            }

            CurrentOperand.Text = result.ToString();

            PrevOperand.Text = "";
            Operand.Text = "";
        }
    }
}
