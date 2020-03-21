using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class Calculator
    {

        public string input { get; set; }
        private string value1 { get; set; }
        private string value2 { get; set; }
        private char operation { get; set; }
        private double result { get; set; }
        private bool goBack { get; set; }

        public Calculator()
        {
            
        }

        public void add(String str, TextBox textBox)
        { 
            value1 = textBox.Text;
            operation = '+';
            
        }

        public void sub(String str, TextBox textBox)
        {
            value1 = textBox.Text;
            operation = '-';
            
        }

        public void mult(String str, TextBox textBox)
        {
            value1 = textBox.Text;
            operation = 'X';
            
        }

        public void devide(String str, TextBox textBox)
        {
            value1 = textBox.Text;
            operation = '/';
            
        }

        public void sqrt(String str, TextBox textBox)
        {
            double num1;
            bool isNum1 = double.TryParse(textBox.Text, out num1);
            goBack = false;
            if (isNum1)
            {
                textBox.Text = Math.Sqrt(num1).ToString();
                input = textBox.Text;
            }
        }

        public void exp(String str, TextBox textBox)
        {
            double num1;
            bool isNum1 = double.TryParse(textBox.Text, out num1);
            goBack = false;
            if (isNum1)
            {
                textBox.Text = (1 / num1).ToString();
                input = textBox.Text;
            }
        }

        public void back(TextBox textBox, bool canGoBack)
        {
            if (canGoBack)
            {
                if (double.Parse(textBox.Text) > 0)
                {
                    if (textBox.TextLength > 0)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                        input = textBox.Text;
                    }
                }
                else
                {
                    if (textBox.Text.Length < 3)
                    {
                        textBox.Text = " ";
                    }
                    else
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                        input = textBox.Text;
                    }
                }
            }

        }

        public void neg(TextBox textBox)
        {
            if (textBox.Text != " ")
            {
                textBox.Text = (double.Parse(textBox.Text) * -1).ToString();
                goBack = true;
            }
        }

        public void equals(String str, TextBox textBox)
        {
            value2 = str;
            double num1, num2;
            bool isNum1 = double.TryParse(value1, out num1);
            bool isNum2 = double.TryParse(value2, out num2);
            goBack = false;


            if (isNum1 && isNum2)
            {
                if (operation == '+')
                {
                    result = num1 + num2;
                    textBox.Text = result.ToString();
                    value1 = textBox.Text;
                   
                    
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    textBox.Text = result.ToString();
                    value1 = result.ToString();
                   


                }
                else if (operation == 'X')
                {
                    result = num1 * num2;
                    textBox.Text = result.ToString();
                    value1 = result.ToString();
                    
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        textBox.Text = result.ToString();
                        value1 = result.ToString();
                        
                    }
                    else
                    {
                        textBox.Text = "Error";
                        input = " ";
                        value2 = " ";
                    }

                }

            }
            else
            {
                textBox.Text = "Error, try again.";

            }

        }
    

    }
}
