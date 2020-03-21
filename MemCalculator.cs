using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class MemCalculator : Calculator
    {
        private string memValue { get; set; }

        public MemCalculator() : base()
        {

        }

        public void memStore(TextBox textBox, TextBox 
            textBox2) {

            memValue = textBox.Text;
            textBox2.Text= memValue;
        }

        public void memClear(TextBox textBox) {
            memValue = " ";
            input = " ";
            textBox.Text = "0";
        
        
        }

        public void memRecall(TextBox textBox) { 
            textBox.Text = memValue;
        
        }

        public void memAdd(TextBox textBox, TextBox textBox2) {
            double num1;
            double num2;
            double result;

            bool isNum1 = double.TryParse(textBox.Text, out num1);
            bool isNum2 = double.TryParse(textBox2.Text, out num2);

            if(isNum1 && isNum2)
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }


        }



    }


}
