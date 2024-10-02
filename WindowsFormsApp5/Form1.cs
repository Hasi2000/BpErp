using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //Creating an object of form2
        {
            Form2 signup = new Form2();
            //Navigation
            signup.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string Password = textBox2.Text;

            //validation
            if (userName == "Dill" && Password == "1234")
            {
                MessageBox.Show("Successfully Logged In");
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Loging Credentials Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
