using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oldCalculator_exercise3
{
    public partial class Form1 : Form
    {
        double firstNum, secNum = 0;
        string currentUserInput = string.Empty;
        string previousUserInput = string.Empty;
        string currentOperation = string.Empty;
        bool userCliked = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Handler_Num_Clicked(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (!userCliked && button.Text == "0") return;
            if (currentUserInput.Contains(".") && button.Text == ".") return;
            if (currentUserInput == "0" || !userCliked)
            {
                currentUserInput = button.Text;
            }
            else
            {
                currentUserInput += button.Text;
            }
            
            userCliked= true;
            TxtCurrent.Text = currentUserInput;
            currentOperation = string.Empty;
        }

        private void BtnBackSpaces_Click(object sender, EventArgs e)
        {
            if (!userCliked || currentUserInput == "0")
            {
                userCliked = false;
                return;
            }
            if (currentUserInput.Length == 1 ) 
            {
                currentUserInput = "0";
                userCliked = false;
                this.TxtCurrent.Text = currentUserInput;
                return;
            }
            string res = currentUserInput.Substring(0, currentUserInput.Length - 1);
            currentUserInput = res;
            this.TxtCurrent.Text = currentUserInput;    
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            currentUserInput= "0";
            this.TxtCurrent.Text= currentUserInput;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            currentUserInput= "0";
            previousUserInput = string.Empty;
            this.TxtCurrent.Text= currentUserInput;
            this.TxtPrevious.Text = previousUserInput;
        }

        private void Handler_Operation_Clicked(object sender, EventArgs e)
        {
            string oper = ((Button)sender).Text;
            userCliked = true;
            if (String.IsNullOrEmpty(currentOperation))
            {
                if (String.IsNullOrEmpty(previousUserInput))
                {
                    previousUserInput = currentUserInput + " " + oper;
                }
                else
                {
                    previousUserInput = previousUserInput + " " + currentUserInput + " " + oper;
                }

                
                currentOperation = oper;
            }
            else
            {
                if (string.IsNullOrEmpty(previousUserInput))
                {
                    previousUserInput = currentUserInput + " " + oper;
                }
                else
                {
                previousUserInput = previousUserInput.Substring(0, previousUserInput.Length - 1) + oper;
                }
            }
            firstNum = double.Parse(currentUserInput);
            this.TxtPrevious.Text = previousUserInput;
            currentUserInput = "0";
            this.TxtCurrent.Text = currentUserInput;
        }

      

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            double res = 0;  
            string oper = currentOperation;
            if (!String.IsNullOrEmpty(previousUserInput))
            {
                oper = previousUserInput.Substring(previousUserInput.Length - 1);
                secNum = double.Parse(currentUserInput);
            }
                switch (oper)
                {
                    case "+":
                        {
                            res = firstNum + secNum;
                            break;
                        }
                    case "-":
                        {
                            res = firstNum - secNum;
                            break;
                        }
                    case "*":
                        {
                            res = firstNum * secNum;
                            break;
                        }
                    case "/":
                        {
                            res = firstNum / secNum;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            currentOperation = oper;
            firstNum = res;
            previousUserInput = string.Empty;
            this.TxtPrevious.Text = previousUserInput;
            currentUserInput = res.ToString();
            this.TxtCurrent.Text = currentUserInput;
            userCliked = false;

        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            double currentNum = double.Parse(currentUserInput);
            currentNum *= -1;
            currentUserInput = currentNum.ToString();
            TxtCurrent.Text = currentUserInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
