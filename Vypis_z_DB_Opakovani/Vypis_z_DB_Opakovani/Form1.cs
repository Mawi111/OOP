using System.Configuration;
using System.Data.SqlClient;

namespace Vypis_z_DB_Opakovani
{
    public partial class Form1 : Form
    {
        SqlRepo sqlRepo = new SqlRepo();
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        FormAdd formAdd = new FormAdd();
        public Form1()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var row in sqlRepo.LoadData())
            {
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private void btnSmaz_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count>0)
            {
                var id = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
                sqlRepo.DeleteItem(id);
            }
            else
            {
                MessageBox.Show("Vyberte položku");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlRepo = new SqlRepo();
            formAdd.Show();
        }
    }
}