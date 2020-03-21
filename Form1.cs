using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string button;
        bool goback = true;

        //Calculator calculator = new Calculator();
        MemCalculator memCalculator = new MemCalculator();
        private string input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Takes the value of the numeric button and adds to a string that is displayed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            button = (sender as Button).Text;
            input += button;
            this.textBoxDisplay.Text = " ";
            this.textBoxDisplay.Text += input;
            goback = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            memCalculator.add(input, textBoxDisplay);
            input = " ";
            goback = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = " ";
            input = " ";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            memCalculator.devide(input, textBoxDisplay);
            input = " ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            memCalculator.mult(input, textBoxDisplay);
            input = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            memCalculator.sub(input, textBoxDisplay);
            input = " ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            memCalculator.equals(input, textBoxDisplay);
            goback = false;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            memCalculator.sqrt(input, textBoxDisplay);
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            memCalculator.exp(input, textBoxDisplay);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            memCalculator.back(textBoxDisplay, goback);
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            memCalculator.neg(textBoxDisplay);
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            memCalculator.memClear(textBoxMem);
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            memCalculator.memRecall(textBoxDisplay);
        }

        private void btnMemStore_Click(object sender, EventArgs e)
        {
            memCalculator.memStore(textBoxDisplay, textBoxMem);
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            memCalculator.memAdd(textBoxDisplay, textBoxMem);
        }

        public void textBoxMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
