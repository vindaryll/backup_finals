using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class formCustomer : Form
    {
        Functions func = new();
        public formCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text.Length == 11)
                {
                    pv.customerName = textBox1.Text.ToUpper();
                    pv.customerAddress = textBox2.Text.ToUpper();
                    pv.customerContact = textBox3.Text.ToUpper();

                    FormOrderInterface form = new();
                    this.Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Please fill out everything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 form = new form2();
            this.Close();
            form.Show();
        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            }
        }
    }
}
