using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone
{
    public partial class FormPaymentEpayment : Form
    {
        public FormPaymentEpayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPayment1 payment1 = new FormPayment1();
            payment1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublicVariables.paymentAmount = PublicVariables.totalBill;
            PublicVariables.changeAmount = 0;
            PublicVariables.paymentMethod = "E-PAYMENT";

            FormReceipt form = new FormReceipt();
            form.Show();
            this.Hide();
        }
    }
}
