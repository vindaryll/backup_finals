using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class FormPaymentEpayment : Form
    {
        public FormPaymentEpayment()
        {
            InitializeComponent();
            lblPayment.Text = "PHP " + pv.totalBill.ToString("N2");
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

            FormReceipt form = new();
            form.Show();
            this.Close();
        }
    }
}
