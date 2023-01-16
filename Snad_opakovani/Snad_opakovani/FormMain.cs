using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Snad_opakovani
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);

            //if (txtFirstNum.Text > O && txtPassword.Text == password)
            //{
            //    new FormMain().Show();
            //}
            //else
            //{
            //    MessageBox.Show("Username or password is wrong.");
            //}

            double result = FirstNum + SecondNum;

            txtResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);

            double result = FirstNum - SecondNum;

            txtResult.Text = result.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);

            double result = FirstNum * SecondNum;

            txtResult.Text = result.ToString();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);

            if (FirstNum == 0 || SecondNum == 0)
            {
                MessageBox.Show("Zero is not good for division!");
            }

            double result = FirstNum / SecondNum;

            txtResult.Text = result.ToString();
        }
    }
}
