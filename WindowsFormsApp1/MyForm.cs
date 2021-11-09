using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* if (button1.Text == "Click")
                 button1.Text = "Hello";
             else
                 button1.Text = "Click";
            */

            string result = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
            MessageBox.Show("Summation: "+result);
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
