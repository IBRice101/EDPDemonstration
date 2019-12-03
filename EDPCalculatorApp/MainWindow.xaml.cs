using System.Windows;

namespace EDPCalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declares number 1 and number 2 as well as an empty string that we will fill to display the I/O
        long number1 = 0;
        long number2 = 0;
        string op = "";

       public static void Welcome()
       {
          MessageBox.Show("This app was made by Isaac Basque-Rice");
       }
    
        public MainWindow()
        {
            InitializeComponent();
            //Welcome();
        }

        //<numberDisplay>
        private void Btn_num0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 *= 10;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= 10;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 1;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 2;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num3_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 3;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 4;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 5;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 6;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 7;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 8;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                numberDisplay.Text = number2.ToString();
            }
        }

        private void Btn_num9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 * 10) + 9;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                numberDisplay.Text = number2.ToString();
            }
        }
        //</numberDisplay>

        //<operatorLogic>
        private void Btn_opAdd_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            numberDisplay.Text = "0";
        }

        private void Btn_opSubtract_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            numberDisplay.Text = "0";
        }

        private void Btn_opMultiply_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            numberDisplay.Text = "0";
        }

        private void Btn_opDivide_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            numberDisplay.Text = "0";
        }
        //</operatorLogic>

        //<onEqualsClick>
        private void Btn_opEquals_Click(object sender, RoutedEventArgs e)
        {
            //the part that actually performs the operation 
            if (op == "+")
            {
                numberDisplay.Text = (number1 + number2).ToString();
            }
            else if (op == "-")
            {
                numberDisplay.Text = (number1 - number2).ToString();
            }
            else if (op == "*")
            {
                numberDisplay.Text = (number1 * number2).ToString();
            }
            else if (op == "/")
            {
                numberDisplay.Text = (number1 / number2).ToString();
            }
            else if (op == "")
            {
                op = "+";
            }
            else
            {
                numberDisplay.Text = number1.ToString();
            }

            //makes a string array and adds all aspects of the equation into the array
            string[] toFile = new string[5];
            toFile[0] = number1.ToString();
            toFile[1] = op;
            toFile[2] = number2.ToString();
            toFile[3] = " = ";
            toFile[4] = numberDisplay.ToString();

            //converts the string array back into a string and outputs it, then goes to a new line
            string toFileString = $"{number1.ToString()} {op} {number2.ToString()} = {numberDisplay.Text} \r\n";

            //appends toFileString to the end of a text document 
            System.IO.File.AppendAllText("CalculatorOutput.txt", toFileString);

        }
        //</onEqualsClick>

        //<clearEntry>
        private void Btn_clrClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = 0;
                numberDisplay.Text = "0";
            }
            else
            {
                number2 = 0;
                numberDisplay.Text = "0";
            }
        }
        //</clearEntry>

        //<clearAll>
        private void Btn_clrClearAll_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            op = "";
            numberDisplay.Text = "0";
        }
        //</clearAll>

        //TODO: find a way of implementing this without having to /10, as this would not work with decimal implementation
        //<backspace>
        private void Btn_clrBack_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = (number1 / 10);
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                numberDisplay.Text = number2.ToString();
            }
        }
        //</backspace>

        //<negativeNumber>
        private void Btn_symPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 *= -1;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                numberDisplay.Text = number2.ToString();
            }
        }
        //</negativeNumber>


        private void Btn_symSmiley_Click(object sender, RoutedEventArgs e)
        {
            Smiley popup = new Smiley();
            popup.Show();
        }
    }
}
