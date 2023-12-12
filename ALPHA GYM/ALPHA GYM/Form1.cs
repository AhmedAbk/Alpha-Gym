namespace ALPHA_GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = username.Text;
            string enteredPassword = pw.Text;

            if (!string.IsNullOrEmpty(enteredUsername) && !string.IsNullOrEmpty(enteredPassword))
            {
                if (enteredUsername == "admin" && enteredPassword == "admin")
                {
                    espaceadmin form2 = new espaceadmin();
                    form2.Show();
                    this.Hide();
                }
                else if (enteredUsername != "admin")
                {
                    MessageBox.Show("Invalid username. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (enteredPassword != "admin")
                {
                    MessageBox.Show("Invalid password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in both username and password fields.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
