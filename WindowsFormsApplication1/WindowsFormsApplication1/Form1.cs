using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            string op;
            
            op = textBox3.Text;
            if (op == "+")
            {

           int     sum = a + b;
                textBox3.Text = Convert.ToString(sum);
            }
            else if (op == "-")
            {

             int   sub = a - b;
                textBox3.Text = Convert.ToString(sub);
            }
            else if (op == "*")
            {

              int  mul = a * b;
                textBox3.Text = Convert.ToString(mul);
            }
            else if (op == "/")
            {

                int div = a / b;
                textBox3.Text = Convert.ToString(div);
            }
            else
            {
                MessageBox.Show("Enter valid operation.");
            }
           
        }
    
            
        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
        }
}
}
