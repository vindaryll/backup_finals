namespace backbone.AdminForms
{
    public partial class dItemForm : Form
    {
        public dItemForm()
        {
            InitializeComponent();

            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userFormItem2 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userFormItem3 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cAdmin1 form = new();
            form.Show();
            panel1.Controls.Clear();
            this.Close();
        }

    }
}
