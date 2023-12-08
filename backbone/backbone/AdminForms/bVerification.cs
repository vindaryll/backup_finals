using pv = backbone.PublicVariables;


namespace backbone.AdminForms
{
    public partial class bVerification : Form
    {
        public bVerification()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForms.aLoginForm form = new();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string verify = textBox1.Text;
            if (string.IsNullOrEmpty(verify))
            {
                MessageBox.Show("Please fill out everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verify == pv.verification)
                {
                    MessageBox.Show("Access granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bChangepass form = new();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Access denied!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                }
            }
        }
    }
}
