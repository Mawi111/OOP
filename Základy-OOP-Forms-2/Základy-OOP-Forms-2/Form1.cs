namespace Základy_OOP_Forms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            int vek = Convert.ToInt32(ageTxt.Text);

            if (vek <= 14)
            {
                MessageBox.Show("Děti nepatří ma seznamku! Jdi pryč!");
            }
            else
            {
                if ((vek <= 21))
                {
                    MessageBox.Show("Byl jsi přiřazen mezi teenagery.");
                }
                else
                {
                    if (vek<=35)
                    {
                        MessageBox.Show("Byl jsi přiřazen mezi dospělé.");
                    }
                    else
                    {
                        if (vek <= 50)
                        {
                            MessageBox.Show("Byl jsi přiřazne mezi pokročilé dospělé.");
                        }
                        else
                        {
                            if (vek >=65)
                            {
                                MessageBox.Show("Byl jsi přiřazen mezi důchodce.");
                            }
                        }
                    }
                }
            }
            //else if (vek <=21)
            //{
            //    MessageBox.Show("Byl jsi přiřazen mezi mladé dospělé");
            //}
            //else if (vek <=40)
            //{
            //    MessageBox.Show("Byl jsi přiřazen mezi dospělé středního věku");
            //}
            //else if (vek >= 60) 
            //{
            //    MessageBox.Show("Byl jsi přiřazen mezi seniory.");
            //}
        }
    }
}