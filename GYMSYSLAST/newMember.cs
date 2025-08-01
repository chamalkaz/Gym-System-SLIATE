using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYMSYSLAST
{
    public partial class newMember : Form
    {
        public newMember()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname=txtFirstName.Text;
            String lname=txtLastName.Text;

            String gender = "";

            bool ischecked = radioButton1.Checked;
            if (ischecked)
            {
                gender=radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String Weight=txtWeight.Text;
            String jdate=dateTimePickerJoined.Text;
            String membership=comboBoxMembership.Text;
            String address=txtWeight.Text;




            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-HMC8E6O;database=gym;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText= "insert into NewMemberr(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Weightt,Maddress,MembershipTime) values ('"+ fname +"','"+ lname + "','" + gender+ "','" + dob+"','" + mobile + "','" + email + "','" + jdate + "','" + Weight + "','" + address + "','" + membership +"')";
            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");




            if (String.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                errorProvider1.SetError(txtFirstName, "Firstname is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                errorProvider2.SetError(txtLastName, "Lastname is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtLastName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                errorProvider3.SetError(txtLastName, "MemberID is required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtLastName, String.Empty);
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            
            txtMobile.Clear();
            txtEmail.Clear();
            txtWeight.Clear();

            comboBoxMembership.ResetText();
            txtAddress.Clear();
            dateTimePickerDOB.Value=DateTime.Now;
            dateTimePickerJoined.Value=DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void newMember_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
