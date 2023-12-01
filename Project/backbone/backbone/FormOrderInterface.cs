using MySql.Data.MySqlClient;
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
    
    public partial class FormOrderInterface : Form
    {
        DbConnect dbcon = new DbConnect();
        Functions func = new Functions();

        public FormOrderInterface()
        {
            InitializeComponent();
            getBtnNames();
            lblTotalBill.Text = PublicVariables.totalBill.ToString();

        }

        private void getBtnNames()
        {
            for (int i = 0; i < 22; i++)
            {
                var button = this.Controls.Find($"button{i + 1}", true).FirstOrDefault() as Button;

                if (button != null && i < PublicVariables.itemName.Length)
                {
                    button.Text = PublicVariables.itemName[i];
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            formCustomer fc = new formCustomer();
            this.Hide();
            fc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 0;
            isAvailable(PublicVariables.indexItem);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 1;
            isAvailable(PublicVariables.indexItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 2;
            isAvailable(PublicVariables.indexItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 3;
            isAvailable(PublicVariables.indexItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 4;
            isAvailable(PublicVariables.indexItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 5;
            isAvailable(PublicVariables.indexItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 6;
            isAvailable(PublicVariables.indexItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 7;
            isAvailable(PublicVariables.indexItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 8;
            isAvailable(PublicVariables.indexItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 9;
            isAvailable(PublicVariables.indexItem);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 10;
            isAvailable(PublicVariables.indexItem);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 11;
            isAvailable(PublicVariables.indexItem);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 12;
            isAvailable(PublicVariables.indexItem);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 13;
            isAvailable(PublicVariables.indexItem);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 14;
            isAvailable(PublicVariables.indexItem);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 15;
            isAvailable(PublicVariables.indexItem);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 16;
            isAvailable(PublicVariables.indexItem);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 17;
            isAvailable(PublicVariables.indexItem);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 18;
            isAvailable(PublicVariables.indexItem);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 19;
            isAvailable(PublicVariables.indexItem);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 20;
            isAvailable(PublicVariables.indexItem);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 21;
            isAvailable(PublicVariables.indexItem);
        }



        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            FormViewOrder oi = new FormViewOrder();
            this.Hide();
            oi.Show();
        }

        private void btnVoidOrder_Click(object sender, EventArgs e)
        {
            func.VarReset();
            Form1 form = new Form1();
            MessageBox.Show("ORDER'S SUCCESSFULLY CANCELED");
            form.Show();
            this.Hide();
        }

        private void isAvailable(int index)
        {
            if (PublicVariables.itemAvailability[PublicVariables.indexItem])
            {
                order();
            }
            else
            {
                MessageBox.Show("Sorry, the Item is Unavailable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void order()
        {
            FormOrderItem oi = new FormOrderItem();
            oi.Show();
            this.Hide();
        }
    }
}
