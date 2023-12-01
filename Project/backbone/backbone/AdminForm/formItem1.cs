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
    public partial class formItem1 : UserControl
    {
        Functions func = new Functions();
        public formItem1()
        {
            InitializeComponent();
            PictureBox[] pictureBoxArray = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            func.mainDish(pictureBoxArray);
        }

        private void btnUpdatePrice1_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 0;
            proceedPrice();
            
        }
        private void btnAvailability1_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 0;
            proceedAvailability();
        }
        private void btnUpdatePrice2_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 1;
            proceedPrice();
        }
        private void btnAvailability2_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 1;
            proceedAvailability();
        }
        private void btnUpdatePrice3_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 2;
            proceedPrice();
        }
        private void btnAvailability3_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 2;
            proceedAvailability();
        }
        private void btnUpdatePrice4_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 3;
            proceedPrice();
        }
        private void btnAvailability4_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 3;
            proceedAvailability();
        }
        private void btnUpdatePrice5_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 4;
            proceedPrice();
        }
        private void btnAvailability5_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 4;
            proceedAvailability();
        }
        private void btnUpdatePrice6_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 5;
            proceedPrice();
        }
        private void btnAvailability6_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 5;
            proceedAvailability();
        }
        private void btnUpdatePrice7_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 6;
            proceedPrice();
        }
        private void btnAvailability7_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 6;
            proceedAvailability();
        }
        private void btnUpdatePrice8_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 7;
            proceedPrice();
        }
        private void btnAvailability8_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 7;
            proceedAvailability();
        }
        private void btnUpdatePrice9_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 8;
            proceedPrice();
        }
        private void btnAvailability9_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 8;
            proceedAvailability();
        }
        private void btnUpdatePrice10_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 9;
            proceedPrice();
        }
        private void btnAvailability10_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 9;
            proceedAvailability();
        }

        private void proceedPrice()
        {
            eUpdateForm form = new eUpdateForm();
            form.Show();
        }

        private void proceedAvailability()
        {
            eAvailability form = new();
            form.Show();
        }

    }
}
