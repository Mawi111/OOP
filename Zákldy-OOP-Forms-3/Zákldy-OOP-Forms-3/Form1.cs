namespace Zákldy_OOP_Forms_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusBTN_Click(object sender, EventArgs e)
        {
            int a = (int)Convert.ToDouble(frnuNUD.Value);
            int b = (int)Convert.ToDouble(frnuNUD.Value);

            int c = a +b;
            MessageBox.Show("Výsledek: " + c);

        }

        private void minusBTN_Click(object sender, EventArgs e)
        {
            int a = (int)Convert.ToDouble(frnuNUD.Value);
            int b = (int)Convert.ToDouble(frnuNUD.Value);

            int c = a - b;
            if (b > a)
            {
                MessageBox.Show("Je mi líto ale do mínusu počítat neumím");
            }
            else
            {
                MessageBox.Show("Výsledek: " + c);
            }
            
        }

        private void multyBTN_Click(object sender, EventArgs e)
        {
            int a = (int)Convert.ToDouble(frnuNUD.Value);
            int b = (int)Convert.ToDouble(frnuNUD.Value);

            int c = a * b;
            MessageBox.Show("Výsledek: " + c);
        }

        private void divisBTN_Click(object sender, EventArgs e)
        {
            int a = (int)Convert.ToDouble(frnuNUD.Value);
            int b = (int)Convert.ToDouble(frnuNUD.Value);

            int c = a / b;
            if (a == 0 || b == 0)
            {
                MessageBox.Show("Nulou dělit nejde");
            }
            else
            {
                MessageBox.Show("Výsledek: " + c);
            }

            
            
            

        }
    }
}