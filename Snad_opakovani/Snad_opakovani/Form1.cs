namespace Snad_opakovani
{
    public partial class Form1 : Form
    {
        private string username = "admin";
        private string password = "admin";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                new FormMain().Show();
            }
            else 
            {
                MessageBox.Show("Username or password is wrong.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}