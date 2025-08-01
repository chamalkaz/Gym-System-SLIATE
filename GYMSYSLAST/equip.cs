using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace GYMSYSLAST
{
    public partial class equip : Form
    {
        public equip()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Equipname=txtEqpName.Text;
            String Descript= txtDes.Text;
            String Mused=txtMucls.Text;
            Int64 Cost= Int64.Parse(txtCost.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-HMC8E6O;database=gym;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into equip(equipName,EDescription,Mused,Cost) values ('" + Equipname + "','" + Descript + "','" + Mused + "','" + Cost + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Data Saved");

            if (String.IsNullOrEmpty(txtEqpName.Text.Trim()))
            {
                errorProvider1.SetError(txtEqpName, "Equipmentname is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEqpName, String.Empty);
            }
            if (String.IsNullOrEmpty(txtEid.Text.Trim()))
            {
                errorProvider2.SetError(txtEid, "EquipmentID is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtEid, String.Empty);
            }
            MessageBox.Show("Data saved");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtEqpName.Clear();
            txtMucls.Clear();
            txtCost.Clear();
            txtEid.Clear();
            txtDes.Clear();
        }
        private void equip_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewEquip ve = new viewEquip();
            ve.Show();
        }
    }
}
