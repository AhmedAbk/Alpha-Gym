using System;
using System.Windows.Forms;

namespace ALPHA_GYM
{
    public partial class espaceadmin : Form
    {
        public espaceadmin()
        {
            InitializeComponent();
        }

        private void gererClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererC gererCForm = new GererC();
            gererCForm.Show();
        }

        private void gererEquipementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererE gererEForm = new GererE();
            gererEForm.Show();
        }

        private void gererStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererS gererSForm = new GererS();
            gererSForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
                if (result == DialogResult.Yes)
                { 
                    Application.Exit();
                } 
           
        }
    }
}
