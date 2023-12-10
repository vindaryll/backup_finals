using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class FormPaymentEpayment : Form
    {
        public FormPaymentEpayment()
        {
            InitializeComponent();
            lblPayment.Text = "PHP " + pv.totalBill.ToString("N2");
            useCustomFont();
        }

        private void useCustomFont()
        {
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(pv.font);
                foreach (Control c in this.Controls)
                {
                    c.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                }
                lblPayment.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormPayment1 form = new();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.paymentAmount = pv.totalBill;
            pv.changeAmount = 0;
            pv.paymentMethod = "E-PAYMENT";

            MiscForms.ReceiptLoading form = new();
            form.Show();
            this.Close();
        }

        private void FormPaymentEpayment_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
        }
    }
}
