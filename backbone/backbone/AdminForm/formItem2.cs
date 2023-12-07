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

namespace backbone.AdminForm
{
    public partial class formItem2 : UserControl
    {
        Functions func = new();
        public formItem2()
        {
            InitializeComponent();
            PictureBox[] pictureBoxArray = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            func.sideDish(pictureBoxArray);
            getNames();
        }

        private void getNames()
        {
            for (int i = 10; i <= 15; i++)
            {
                var label = this.Controls.Find($"name{i - 9}", true).FirstOrDefault() as Label;

                if (label != null && i < pv.itemName.Length)
                {
                    label.Text = pv.itemName[i];
                }
            }
        }

        private void btnUpdatePrice1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 10;
            proceedPrice();
        }
        private void btnAvailability1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 10;
            proceedAvailability();
        }
        private void btnUpdatePrice2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 11;
            proceedPrice();
        }
        private void btnAvailability2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 11;
            proceedAvailability();
        }
        private void btnUpdatePrice3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 12;
            proceedPrice();
        }
        private void btnAvailability3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 12;
            proceedAvailability();
        }
        private void btnUpdatePrice4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 13;
            proceedPrice();
        }
        private void btnAvailability4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 13;
            proceedAvailability();
        }
        private void btnUpdatePrice5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 14;
            proceedPrice();
        }
        private void btnAvailability5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 14;
            proceedAvailability();
        }

        private void proceedPrice()
        {
            CloseItemForm();
            eUpdatePrice form = new eUpdatePrice();
            form.Show();
        }

        private void proceedAvailability()
        {
            CloseItemForm();
            eUpdateAvailability form = new();
            form.Show();
        }

        private void CloseItemForm()
        {
            if (ParentForm is dItemForm itemForm)
            {
                itemForm.Close();
            }
        }
    }
}
