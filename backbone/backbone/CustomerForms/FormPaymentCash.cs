using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class FormPaymentCash : Form
    {
        public FormPaymentCash()
        {
            InitializeComponent();
            lblTotal.Text = "PHP " + pv.totalBill.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out pv.paymentAmount))
                {

                    if (pv.paymentAmount >= pv.totalBill)
                    {
                        pv.changeAmount = pv.paymentAmount - pv.totalBill;
                        pv.paymentMethod = "CASH";
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("PLEASE ENTER SUFFICIENT AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("INVALID AMOUNT. PLEASE ENTER A NUMERIC VALUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER AN AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (valid)
            {
                FormReceipt form = new();
                form.Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPayment1 form = new();
            form.Show();
            this.Close();
        }
    }
}
