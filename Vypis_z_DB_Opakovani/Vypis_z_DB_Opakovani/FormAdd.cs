using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vypis_z_DB_Opakovani
{
    public partial class FormAdd : Form
    {
        SqlRepo sqlRepo = new SqlRepo();
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var id = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
            sqlRepo.DeleteItem(id);
        }
    }
}
