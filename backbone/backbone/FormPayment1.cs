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
    public partial class FormPayment1 : Form
    {
        public FormPayment1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPaymentCash form = new FormPaymentCash();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormViewOrder form = new FormViewOrder();
            form.Show(); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPaymentEpayment form = new FormPaymentEpayment();
            form.Show();
            this.Close();
        }
    }
}
