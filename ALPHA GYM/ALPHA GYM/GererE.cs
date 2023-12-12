using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ALPHA_GYM
{
    public partial class GererE : Form
    {
        DataTable tableE = new DataTable("tableE");
        int index;
        List<equipment> equipments = new List<equipment>();

        public GererE()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                nometxt.Text = selectedRow.Cells["Nom"].Value.ToString();
                destxt.Text = selectedRow.Cells["Description"].Value.ToString();
                poidtxt.Text = selectedRow.Cells["Poids"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["Muscle"].Value.ToString();
                comboBox2.SelectedItem = selectedRow.Cells["Type"].Value.ToString();
            }
        }

        private void ajoutbtn_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                equipment newEquipment = new equipment
                {
                    nom = nometxt.Text,
                    description = destxt.Text,
                    poids = int.Parse(poidtxt.Text),
                    muscle = comboBox1.SelectedItem?.ToString(),
                    type = comboBox2.SelectedItem?.ToString()
                };

                equipments.Add(newEquipment);
                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private bool validateInput()
        {
            if (!int.TryParse(poidtxt.Text, out _))
            {
                MessageBox.Show("Veuillez entrer une valeur numérique valide pour 'Poids'.", "Saisie invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void majbtn_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                if (index >= 0 && index < equipments.Count)
                {
                    equipment selectedEq = equipments[index];
                    selectedEq.nom = nometxt.Text;
                    selectedEq.description = destxt.Text;
                    selectedEq.poids = int.Parse(poidtxt.Text);
                    selectedEq.muscle = comboBox1.SelectedItem?.ToString();
                    selectedEq.type = comboBox2.SelectedItem?.ToString();
                    UpdateDataGridView();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un équipement à mettre à jour.", "Aucun équipement sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void supbtn_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < equipments.Count)
            {
                equipments.RemoveAt(index);
                UpdateDataGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un équipement à supprimer.", "Aucun équipement sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputFields()
        {
            nometxt.Text = string.Empty;
            destxt.Text = string.Empty;
            poidtxt.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void UpdateDataGridView()
        {
            tableE.Clear();
            foreach (var eq in equipments)
            {
                tableE.Rows.Add(eq.nom, eq.description, eq.poids, eq.muscle, eq.type);
            }
            dataGridView1.DataSource = tableE;
        }

        private void GererE_Load(object sender, EventArgs e)
        {
            tableE.Columns.Add("Nom");
            tableE.Columns.Add("Description");
            tableE.Columns.Add("Poids");
            tableE.Columns.Add("Muscle");
            tableE.Columns.Add("Type");

            comboBox1.Items.AddRange(new object[] { "Poitrine", "Dorsaux", "Jambes", "Épaules", "Biceps", "Triceps" });
            comboBox2.Items.AddRange(new object[] { "Câble", "Barre", "Haltères", "Autres" });
        }
    }
}