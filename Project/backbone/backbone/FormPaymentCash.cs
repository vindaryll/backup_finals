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
    public partial class FormPaymentCash : Form
    {
        public FormPaymentCash()
        {
            InitializeComponent();
            lblTotal.Text = PublicVariables.totalBill.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (double.TryParse(textBox1.Text, out PublicVariables.paymentAmount))
                    {

                        if (PublicVariables.paymentAmount >= PublicVariables.totalBill)
                        {
                            PublicVariables.changeAmount = PublicVariables.paymentAmount - PublicVariables.totalBill;
                            PublicVariables.paymentMethod = "CASH";
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
                // receipt na
                FormReceipt form = new FormReceipt();
                form.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPayment1 form = new FormPayment1();
            form.Show();
            this.Hide();
        }
    }
}
