namespace backbone.CustomerForms
{
    public partial class FormPayment1 : Form
    {
        public FormPayment1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPaymentCash form = new();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormViewOrder form = new();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPaymentEpayment form = new();
            form.Show();
            this.Close();
        }
    }
}
