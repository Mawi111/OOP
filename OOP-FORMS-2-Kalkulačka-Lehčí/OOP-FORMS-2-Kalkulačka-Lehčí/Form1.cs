namespace OOP_FORMS_2_Kalkulačka_Lehčí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVypocti_Click(object sender, EventArgs e)
        {
            string operace = comboBox1.SelectedItem.ToString();
            double cislo1 = Convert.ToDouble(numericUpDown1.Value);
            double cislo2 = Convert.ToDouble(numericUpDown2.Value);
            double vysledek = 0;

            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
            }
            else if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
            }
            else if (operace == "*")
            {
                vysledek = cislo1 * cislo2;
            }
            else if (operace == "/")
            {
                if ( cislo1 == 0 || cislo2 == 0)
                {
                    MessageBox.Show("Nulou dělit nelze");
                }
                else
                {
                    vysledek = cislo1 / cislo2;
                }
                
            }

            lblVysledek.Text = vysledek.ToString();
        }
    }
}