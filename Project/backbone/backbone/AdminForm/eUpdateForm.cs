using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone.AdminForm
{
    public partial class eUpdateForm : Form
    {
        Functions func = new();
        public eUpdateForm()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {
            func.getCurrentPrice(PublicVariables.adminItemIndex);
            lblPrice.Text = PublicVariables.currentPrice.ToString("N2");
            func.picture(PublicVariables.adminItemIndex, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter a Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(textBox1.Text, out price)) 
            {
                func.updatePrice(price, PublicVariables.adminItemIndex);
                MessageBox.Show("Price Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                func.getItemInfo();
                showdata();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dItemForm form = new();
            //form.Show();
            this.Close();
        }
    }
}
