using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class aLoginForm : Form
    {
        Functions func = new Functions();
        public aLoginForm()
        {
            InitializeComponent();
            func.getAdminInfo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bVerification form = new();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            else
            {
                if (username == pv.username && password == pv.password)
                {
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cAdmin1 form = new();
                    form.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 form = new();
            form.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aLoginForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
            linkLabel1.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
        }
    }
}
