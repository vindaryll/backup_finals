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
    public partial class formItem3 : UserControl
    {
        Functions func = new();
        public formItem3()
        {
            InitializeComponent();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7};
            func.beverages(pictureBoxes);
        }

        private void btnUpdatePrice1_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 15;
            proceedPrice();
        }

        private void btnUpdatePrice2_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 16;
            proceedPrice();
        }

        private void btnUpdatePrice3_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 17;
            proceedPrice();
        }

        private void btnUpdatePrice4_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 18;
            proceedPrice();
        }

        private void btnUpdatePrice5_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 19;
            proceedPrice();
        }

        private void btnUpdatePrice6_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 20;
            proceedPrice();
        }

        private void btnUpdatePrice7_Click(object sender, EventArgs e)
        {
            PublicVariables.adminItemIndex = 21;
            proceedPrice();
        }

        private void proceedPrice()
        {
            eUpdateForm form = new eUpdateForm();
            form.Show();
        }
    }
}
