using pv = backbone.PublicVariables;

namespace backbone
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
            FormPayment1 payment1 = new FormPayment1();
            payment1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.paymentAmount = pv.totalBill;
            pv.changeAmount = 0;
            pv.paymentMethod = "E-PAYMENT";

            FormReceipt form = new FormReceipt();
            form.Show();
            this.Close();
        }
    }
}
