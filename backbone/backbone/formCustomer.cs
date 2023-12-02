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
    public partial class formCustomer : Form
    {
        Functions func = new Functions();
        public formCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                PublicVariables.customerName = textBox1.Text.ToUpper();
                PublicVariables.customerAddress = textBox2.Text.ToUpper();
                PublicVariables.customerContact = textBox3.Text.ToUpper();


                //FormOrderInterface orderinterface = new FormOrderInterface();
                //this.Hide();
                //orderinterface.Show();
                FormOrderInterface form = new();
                this.Close();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please fill out everything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            this.Hide();
            f2.Show();
        }
    }
}
