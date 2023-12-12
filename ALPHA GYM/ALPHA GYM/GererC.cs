using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ALPHA_GYM
{
    public partial class GererC : Form
    {
        DataTable table = new DataTable("table");
        int index;
        List<Client> clients = new List<Client>();

        public GererC()
        {
            InitializeComponent();
        }

        private void ajoutbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Client newClient = new Client
                {
                    Nom = nomtxt.Text,
                    Prenom = pretxt.Text,
                    Num = int.Parse(numtxt.Text),
                    Sexe = radioBtnMale.Checked ? "Homme" : "femme",
                    SelectedPaymentMethod = comboBox1.SelectedItem.ToString()
                };
                clients.Add(newClient);
                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private void majbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Client selectedClient = clients[index];
                selectedClient.Nom = nomtxt.Text;
                selectedClient.Prenom = pretxt.Text;
                selectedClient.Num = int.Parse(numtxt.Text);
                selectedClient.Sexe = radioBtnMale.Checked ? "homme" : "femme";
                selectedClient.SelectedPaymentMethod = comboBox1.SelectedItem.ToString();

                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(nomtxt.Text) || string.IsNullOrWhiteSpace(pretxt.Text) || string.IsNullOrWhiteSpace(numtxt.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Informations manquantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(numtxt.Text, out _))
            {
                MessageBox.Show("Veuillez saisir une valeur numérique valide pour 'Numéro'.", "Saisie invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            nomtxt.Text = string.Empty;
            pretxt.Text = string.Empty;
            numtxt.Text = string.Empty;
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
        }

        private void UpdateDataGridView()
        {
            table.Clear();
            foreach (var client in clients)
            {
                table.Rows.Add(client.Nom, client.Prenom, client.Num, client.Sexe, client.SelectedPaymentMethod);
            }
        }

        private void GererC_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prénom", typeof(string));
            table.Columns.Add("Numéro", typeof(int));
            table.Columns.Add("Sexe", typeof(string));
            table.Columns.Add("Méthode de paiement", typeof(string));
            dataGridView1.DataSource = table;

            comboBox1.Items.AddRange(new string[] { "Payer Au Gichet", "Carte Bancaire" });

            Client defaultClient = new Client();
            comboBox1.SelectedItem = defaultClient.SelectedPaymentMethod;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < clients.Count)
            {
                Client selectedClient = clients[index];
                nomtxt.Text = selectedClient.Nom;
                pretxt.Text = selectedClient.Prenom;
                numtxt.Text = selectedClient.Num.ToString();

                if (selectedClient.Sexe == "homme")
                {
                    radioBtnMale.Checked = true;
                }
                else
                {
                    radioBtnFemale.Checked = true;
                }
            }
        }

        private void supbtn_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < clients.Count)
            {
                clients.RemoveAt(index);
                UpdateDataGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}