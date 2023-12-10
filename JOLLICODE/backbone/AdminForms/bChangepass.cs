using System.Drawing.Text;

namespace backbone.AdminForms
{
    public partial class bChangepass : Form
    {
        Functions func = new();
        public bChangepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            string pass2 = textBox2.Text;

            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Please fill out everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pass == pass2)
                {
                    func.updatePass(pass);
                    MessageBox.Show("The password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    aLoginForm form = new();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void bChangepass_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
