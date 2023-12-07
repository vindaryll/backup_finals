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
    public partial class FormEditOrder : Form
    {
        Functions func = new();
        public FormEditOrder()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            func.picture(pv.indexItem, pictureBox1);
            lblItemName.Text = pv.itemName[pv.indexItem].ToString();
            lblPrice.Text = pv.itemPrice[pv.indexItem].ToString("N2");
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = pv.mealTotal[pv.indexItem].ToString("N2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                if (pv.itemQuantity[pv.indexItem] == 1)
                {
                    DialogResult option = MessageBox.Show($"Are you sure to remove item no.{pv.indexItem + 1}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes) {
                        // If the user clicks "Yes", the system will remove the item and will automatically get back to designated interface
                        minus();
                        getBack(); 
                    }
                    // If the user clicks "No", do nothing
                }
                else
                {
                    minus();
                }

            }
            else
            {
                // nothing to show
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getBack();
        }


        private void add()
        {
            pv.itemQuantity[pv.indexItem] += 1;
            pv.mealTotal[pv.indexItem] += pv.itemPrice[pv.indexItem];
            pv.totalBill += pv.itemPrice[pv.indexItem];
            pv.totalQuantity += 1;
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void minus()
        {
            pv.itemQuantity[pv.indexItem] -= 1;
            pv.mealTotal[pv.indexItem] -= pv.itemPrice[pv.indexItem];
            pv.totalBill -= pv.itemPrice[pv.indexItem];
            pv.totalQuantity -= 1;
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void getBack()
        {
            if (pv.totalQuantity > 0)
            {
                FormViewOrder form = new();
                form.Show();
                this.Close();
            }
            else
            {
                FormOrderInterface form = new();
                form.Show();
                this.Close();
            }
        }
    }
}
