using MySqlX.XDevAPI.Common;
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
    public partial class eAvailability : Form
    {
        Functions func = new();
        bool avail; // variable for availability
        public eAvailability()
        {
            InitializeComponent();
            showData();
        }


        private void showData()
        {
            func.getItemInfo();
            func.picsUpdate(pv.adminItemIndex, button1, button2);
            func.picture(pv.adminItemIndex, pictureBox1);
            label1.Text = pv.itemName[pv.adminItemIndex].ToString();
            label2.Text = $"ITEM ID: {pv.itemID[pv.adminItemIndex]}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pv.itemAvailability[pv.adminItemIndex])
            {
                DialogResult result = MessageBox.Show($"Do you want to set Item {pv.itemID[pv.adminItemIndex]} into available?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    avail = true;
                    func.updateAvailability(pv.adminItemIndex, avail);
                    MessageBox.Show("Availability Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }

            }
            else
            {
                // nothing to show
            }           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemAvailability[pv.adminItemIndex])
            {
                DialogResult result = MessageBox.Show($"Do you want to set Item number: {pv.itemID[pv.adminItemIndex]} into unavailable?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    avail = false;
                    func.updateAvailability(pv.adminItemIndex, avail);
                    MessageBox.Show("Availability Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }

            }
            else
            {
                // nothing to show
            }
        }
    }
}
