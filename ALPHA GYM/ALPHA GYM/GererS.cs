using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALPHA_GYM
{
    public partial class GererS : Form
    {
        DataTable tablec = new DataTable("tablec");
        int index;
        List<Staff> Staffs = new List<Staff>();

        public GererS()
        {
            InitializeComponent();
        }





        private bool ValidateInput(bool updating)
        {
            if (!updating && (string.IsNullOrWhiteSpace(nomstxt.Text) || string.IsNullOrWhiteSpace(prestxt.Text) || string.IsNullOrWhiteSpace(numstxt.Text) || string.IsNullOrWhiteSpace(ansstxt.Text)))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(numstxt.Text, out int numValue))
            {
                MessageBox.Show("Please enter a valid numeric value for 'Num'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(ansstxt.Text, out int ansValue))
            {
                MessageBox.Show("Please enter a valid numeric value for 'Ans dexperience'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            nomstxt.Text = string.Empty;
            prestxt.Text = string.Empty;
            numstxt.Text = string.Empty;
            radiosBtnMale.Checked = false;
            radiosBtnFemale.Checked = false;
            anstxt.Text = string.Empty;
        }

        private void UpdateDataGridView()
        {
            tablec.Clear();

            foreach (var staff in Staffs)
            {
                tablec.Rows.Add(staff.Nom, staff.Prenom, staff.Num, staff.Sexe, staff.ans);  
            }

            dataGridView1.DataSource = tablec;
        }





        private void ajoutsbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput(true))
            {
                Staff newStaff = new Staff
                {
                    Nom = nomstxt.Text,
                    Prenom = prestxt.Text,
                    Num = int.Parse(numstxt.Text),
                    Sexe = radiosBtnMale.Checked ? "Male" : "Female",
                    ans = int.Parse(ansstxt.Text)
                };

                Staffs.Add(newStaff);
                UpdateDataGridView();
                ClearInputFields();
            }
        }


        private void supsbtn_Click(object sender, EventArgs e)
        {

            if (index >= 0 && index < Staffs.Count)
            {
                Staffs.RemoveAt(index);
                UpdateDataGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a Staff to delete.", "No Staff Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < Staffs.Count)
            {
                Staff selectedStaff = Staffs[index];
                nomstxt.Text = selectedStaff.Nom;
                prestxt.Text = selectedStaff.Prenom;
                numstxt.Text = selectedStaff.Num.ToString();

                if (selectedStaff.Sexe == "Male")
                {
                    radiosBtnMale.Checked = true;
                }
                else
                {
                    radiosBtnFemale.Checked = true;
                }
            }
        }

        private void GererS_Load(object sender, EventArgs e)
        {
            tablec.Columns.Add("Nom", typeof(string));
            tablec.Columns.Add("Prenom", typeof(string));
            tablec.Columns.Add("Num", typeof(int));
            tablec.Columns.Add("Sexe", typeof(string));
            tablec.Columns.Add("Ans dexperience", typeof(int));
            dataGridView1.DataSource = tablec;
        }

        private void majsbtn_Click(object sender, EventArgs e)
        {
            {
                if (ValidateInput(true))
                {
                    Staff selectedStaff = Staffs[index];
                    selectedStaff.Nom = nomstxt.Text;
                    selectedStaff.Prenom = prestxt.Text;
                    selectedStaff.Num = int.Parse(numstxt.Text);
                    selectedStaff.Sexe = radiosBtnMale.Checked ? "Male" : "Female";

                    UpdateDataGridView();
                    ClearInputFields();
                }
            }
        }
    }
}