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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void nEWMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMember nm =new newMember();
            nm.Show();
        }

        private void nEWSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newStaff ns=new newStaff();
            ns.Show();
        }

        private void eQUIPMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equip eq= new equip();
            eq.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOG OUT || confirm?", "log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
            this.Close();
            Form1 lg=new Form1 ();
                lg.Show();
                
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void dELETEMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmi bm = new bmi();    
            bm.Show();
        }

        private void sERACHMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchMem sm = new searchMem();
            sm.Show();
        }
    }
}
