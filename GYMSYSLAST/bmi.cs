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
    public partial class bmi : Form
    {
        public bmi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBmi_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtWeight.Text);
            double num2 = double.Parse(txtHeight.Text);

            double meter = num2 / 100;
            double bmi = num1 / (meter*meter);

            txtBmi.Text=bmi.ToString();


            if (bmi <= 18.5)
            {
                lblStatus.Text = "Under Weight";
                lblStatus.ForeColor = Color.Yellow;
            }
            else if(bmi<=25)
            {
                lblStatus.Text = "Normal Weight";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Over Weight";
                lblStatus.ForeColor = Color.Red;
            }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            txtBmi.Clear();
            lblStatus.Text = "";
        }

        private void bmi_Load(object sender, EventArgs e)
        {

        }
    }
}
