namespace OOP_FORM_1_Kalkulačka
{
    public partial class Form1 : Form
    {
        public int cislo { get; set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1 = 1;
            ListViewItem item = new ListViewItem("1");
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cislo2 = 2;
            ListViewItem item = new ListViewItem("2");
            listView1.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("3");
            listView1.Items.Add(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("4");
            listView1.Items.Add(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("5");
            listView1.Items.Add(item);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("6");
            listView1.Items.Add(item);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("7");
            listView1.Items.Add(item);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("8");
            listView1.Items.Add(item);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("9");
            listView1.Items.Add(item);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("0");
            listView1.Items.Add(item);
        }
    }
}