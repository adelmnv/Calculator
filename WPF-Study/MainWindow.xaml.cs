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

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Abstractions.IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string TextBox { get => str.Text; set => str.Text = value; }
        public string TextOp { get => process.Text; set=> process.Text = value; }
        public string Operation { get; set; }
        public string UpOperation { get; set; }
        public int BracketsCount { get; set; }
        public string DopOperation { get; set; }
        public bool IsZero { get; set; }
        public string BracketOp { get; set; }
        public event EventHandler Result;
        public event EventHandler OnTextChanged;
        public event EventHandler SaveValue;
        public event EventHandler Clear;
        public void ClearText()
        {
            str.Text = "0";
            IsZero = false;
        }
        public void ClearOp()
        {
            process.Text = "";
        }
        public void GetResult(string str1)
        {
            str.Text = str1;
        }
        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            ClearText();
            ClearOp();
            BracketsCount = 0;
            UpOperation = "";
            if (Clear != null)
            {
                Clear.Invoke(this, e);
            } 
        }

        private void bOne_Click(object sender, RoutedEventArgs e)
        {
            if(str.Text == "0")
                str.Text = "1";
            else
                str.Text += "1";
            process.Text += "1";
            Operation = "number";
            IsZero = false;
        }
        private void bTwo_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "2";
            else
                str.Text += "2";
            process.Text += "2";
            Operation = "number";
            IsZero = false;
        }
        private void bThree_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "3";
            else
                str.Text += "3";
            process.Text += "3";
            Operation = "number";
            IsZero = false;
        }
        private void bFour_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "4";
            else
                str.Text += "4";
            process.Text += "4";
            Operation = "number";
            IsZero = false;
        }
        private void bFive_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "5";
            else
                str.Text += "5";
            process.Text += "5";
            Operation = "number";
            IsZero = false;
        }
        private void bSix_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "6";
            else
                str.Text += "6";
            process.Text += "6";
            Operation = "number";
            IsZero = false;
        }
        private void bSeven_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "7";
            else
                str.Text += "7";
            process.Text += "7";
            Operation = "number";
            IsZero = false;
        }
        private void bEight_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "8";
            else
                str.Text += "8";
            process.Text += "8";
            Operation = "number";
            IsZero = false;
        }
        private void bNine_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text == "0")
                str.Text = "9";
            else
                str.Text += "9";
            process.Text += "9";
            Operation = "number";
            IsZero = false;
        }
        private void bZero_Click(object sender, RoutedEventArgs e)
        {
            if (str.Text != "0")
                str.Text += "0";
            process.Text += "0";
            Operation = "number";
            IsZero = true;
        }
        private void bTimes_Click(object sender, RoutedEventArgs e)
        {
            if (UpOperation == "equal")
            {
                process.Text = str.Text + " * ";
            }
            else
                process.Text += " * ";

            Operation = "times";
            UpOperation = "";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);

            if (str.Text != "0")
                ClearText();
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";
        }
        private void bPlus_Click(object sender, RoutedEventArgs e)
        {
            if (UpOperation == "equal")
            {
                process.Text = str.Text + " + ";
            }
            else
                process.Text += " + ";

            Operation = "plus";
            UpOperation = "";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);

            if (str.Text != "0")
                ClearText();
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";

        }
        private void bMinus_Click(object sender, RoutedEventArgs e)
        
        {
            if (UpOperation == "equal")
            {
                process.Text = str.Text + " - ";
            }
            else
                process.Text += " - ";

            Operation = "minus";
            UpOperation = "";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);

            if (str.Text != "0")
                ClearText();
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";

        }
        private void bDivide_Click(object sender, RoutedEventArgs e)

        {
            if (UpOperation == "equal")
            {
                process.Text = str.Text + " / ";
            }
            else
                process.Text += " / ";

            Operation = "divide";
            UpOperation = "";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);

            if (str.Text != "0")
                ClearText();
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";

        }
        private void bSqrt_Click(object sender, RoutedEventArgs e)
        {
            if(Operation != "number")
            {
                if (UpOperation == "equal")
                {
                    process.Text = str.Text + "√";
                }
                else
                    process.Text += "√";

                DopOperation = "sqrt";
                UpOperation = "sqrt";
                str.Text = "√";
                if (BracketOp != "")
                    BracketOp = "";
            }
                
        }

        private void bBracket_Click(object sender, RoutedEventArgs e)
        {
            if (BracketsCount == 0)
                BracketsCount = 1;
            else if(BracketsCount == 1)
                    BracketsCount = 2;
            if (UpOperation == "equal")
            {
                if(BracketsCount == 1)
                process.Text = str.Text + " ( ";
                else if(BracketsCount == 2)
                    process.Text = str.Text + " ) ";
            }
            else
            {
                if (BracketsCount == 1)
                    process.Text += " ( ";
                else if (BracketsCount == 2)
                {
                    process.Text += " ) ";
                    BracketOp = "bracket";
                }
            }
            Operation = "bracket";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);
            ClearText();
            if (BracketsCount == 2)
                BracketsCount = 0;
        }

        private void bDegree_Click(object sender, RoutedEventArgs e)
        {
            if (UpOperation == "equal")
            {
                process.Text = str.Text + "^2";
            }
            else
                process.Text += "^2";

            DopOperation = "degree";
            UpOperation = "degree";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);

            if (str.Text != "0")
                ClearText();
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";
        }
        private void bEqual_Click(object sender, RoutedEventArgs e)
        {
            Operation = "equal";
            process.Text += " = ";
            UpOperation = "equal";
            if (!IsZero && str.Text == "0")
                str.Text = "";
            if (SaveValue != null)
                SaveValue.Invoke(this, e);
            if (Result != null)
            {
                Result.Invoke(this, e);
            }
            if (DopOperation != "")
                DopOperation = "";
            if (BracketOp != "")
                BracketOp = "";
        }
        private void strValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OnTextChanged != null)
            {
                OnTextChanged.Invoke(this, e);
            }
        }

    }
}
