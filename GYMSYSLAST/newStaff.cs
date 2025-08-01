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
    public partial class newStaff : Form
    {
        public newStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;

            String gender = "";
            bool isChecked=radioButton1.Checked;

            if (isChecked)
            {
                gender=radioButton1.Text;

            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile=Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String jdate = dateTimePickerJoined.Text;
            String city = txtCity.Text;
            String address=txtAddress.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-HMC8E6O;database=gym;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into newstff(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,City,Address) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + jdate + "','" + city + "','" + address + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");






            if (String.IsNullOrEmpty(txtFname.Text.Trim()))
            {
                errorProvider1.SetError(txtFname, "Firstname is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFname, String.Empty);
            }

            if (String.IsNullOrEmpty(txtLname.Text.Trim()))
            {
                errorProvider2.SetError(txtLname, "Lastname is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtLname, String.Empty);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            
            txtAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoined.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void newStaff_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void btnVstaff_Click(object sender, EventArgs e)
        {
            viewStaff vs=new viewStaff();
            vs.Show();
        }
    }
}
