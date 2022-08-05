using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string address = textBox4.Text;

            DataBaseClass db = new DataBaseClass();
            string querry = "insert into [TestDB].[dbo].[User] values('" + userName + "','" + password + "','" + password + "','" + address + "');";
            db.executeInsertQuerry(querry);
            
        }
    }
}
