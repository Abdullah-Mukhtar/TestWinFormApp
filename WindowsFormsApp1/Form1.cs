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
    public partial class Form1 : Form
    {
        string username = "Abdullah";
        string password = "123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametxtBox.Text == username)
            {
                Registration calc = new Registration();
                calc.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
