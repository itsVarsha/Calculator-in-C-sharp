using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        double firstNo;
        char operation;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "1";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 1;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "7";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 7;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "2";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "3";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "4";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "5";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "6";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "8";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "9";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == null)
            {
                txtDisplay.Text = "0";
            }
            else
                txtDisplay.Text = txtDisplay.Text + 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(txtDisplay.Text);
            operation = '+';
            txtDisplay.Text = "0";
            
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
           
            switch (operation)
            {
                case '+' :
                    result = firstNo + Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(result);
                    break;
                case '-':
                    result = firstNo - Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(result);
                    break;
                case '/':
                    result = firstNo / Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(result);
                    break;
                case '*':
                    result = firstNo * Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(result);
                    break;
                case 'q' :
                    txtDisplay.Text = "0";
                    break;
                    
                default:
                    txtDisplay.Text = "Enter Valid Values";
                    break;


            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(txtDisplay.Text);
            operation = 'x';
            txtDisplay.Text = "0";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(txtDisplay.Text);
            operation = '/';
            txtDisplay.Text = "0";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(txtDisplay.Text);
            operation = '-';
            txtDisplay.Text = "0";

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            operation = 'q';
            txtDisplay.Text = "0";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
