using backbone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pv = backbone.PublicVariables;

namespace backbone
{
    public partial class FormOrderItem : Form
    {

        Functions func = new Functions();
        public FormOrderItem()
        {
            InitializeComponent();
            showData();
        }



        private void showData()
        {
            func.picture(pv.indexItem, pictureBox1);
            lbl1.Text = pv.itemName[pv.indexItem].ToString();
            lbl2.Text = pv.itemPrice[pv.indexItem].ToString("N2");
            lbl3.Text = pv.itemDescription[pv.indexItem].ToString();
            lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
            lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pv.itemQuantity[pv.indexItem] += 1;
            pv.mealTotal[pv.indexItem] += pv.itemPrice[pv.indexItem];
            pv.totalBill += pv.itemPrice[pv.indexItem];
            pv.totalQuantity += 1;
            lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
            lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                pv.itemQuantity[pv.indexItem] -= 1;
                pv.mealTotal[pv.indexItem] -= pv.itemPrice[pv.indexItem];
                pv.totalBill -= pv.itemPrice[pv.indexItem];
                pv.totalQuantity -= 1;
                lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
                lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
            }
            else
            {
                // nothing to show
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                MessageBox.Show("Order Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FormOrderInterface form = new FormOrderInterface();
            form.Show();
            this.Close();
        }

    }
}
