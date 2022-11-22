using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String myoperation = "";
        bool ismyoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInput.Text = "0";
            result = 0;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            UserInput.Clear();
        }

        private void divise_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {

            switch (myoperation)
            {
                case "+":
                    UserInput.Text = (result + Double.Parse(UserInput.Text)).ToString();
                    break;
                case "-":
                    UserInput.Text = (result - Double.Parse(UserInput.Text)).ToString();
                    break;
                case "*":
                    UserInput.Text = (result * Double.Parse(UserInput.Text)).ToString();
                    break;
                case "/":
                    UserInput.Text = (result / Double.Parse(UserInput.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(UserInput.Text);
            label1.Text = "";
        }



        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void multiple_Click(object sender, EventArgs e)
        {

        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((UserInput.Text == "0") || (ismyoperation))
                UserInput.Clear();
            ismyoperation = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!UserInput.Text.Contains("."))
                    UserInput.Text = UserInput.Text + button.Text;

            }
            else
                UserInput.Text = UserInput.Text + button.Text;

        }


        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                equals.PerformClick();
                myoperation = button.Text;
                label1.Text = result + " " + myoperation;
                ismyoperation = true;
            }
            else
            {

                myoperation = button.Text;
                result = Double.Parse(UserInput.Text);
                label1.Text = result + " " + myoperation;
                ismyoperation = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

