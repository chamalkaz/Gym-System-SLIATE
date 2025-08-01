using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMSYSLAST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                menu mn = new menu();
                mn.Show();
                this.Hide();
            }
            else if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username and Password required!");
            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }



            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorProvider1.SetError(textBox1, "Username is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1,String.Empty);
            }

            if (String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider1.SetError(textBox2, "Password is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox2, String.Empty);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
