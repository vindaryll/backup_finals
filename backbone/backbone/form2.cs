namespace backbone
{

    public partial class form2 : Form
    {

        public form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formCustomer fc = new formCustomer();
            this.Close();
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm.aLoginForm form1 = new AdminForm.aLoginForm();
            form1.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
