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
    public partial class formSideDish : UserControl
    {
        Functions func = new();
        public formSideDish()
        {
            InitializeComponent();
            getBtnInfo();
        }

        private void getBtnInfo()
        {
            // names
            for (int i = 10; i <= 15; i++)
            {
                var button = this.Controls.Find($"button{i - 9}", true).FirstOrDefault() as Button;

                if (button != null && i < PublicVariables.itemName.Length)
                {
                    button.Text = PublicVariables.itemName[i];
                }
            }

            // image
            Button[] buttons = { button1, button2, button3, button4, button5 };
            func.sideDishBtns(buttons);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 10;
            isAvailable(PublicVariables.indexItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 11;
            isAvailable(PublicVariables.indexItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 12;
            isAvailable(PublicVariables.indexItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 13;
            isAvailable(PublicVariables.indexItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PublicVariables.indexItem = 14;
            isAvailable(PublicVariables.indexItem);
        }

        private void isAvailable(int index)
        {
            if (PublicVariables.itemAvailability[index])
            {
                order();
                CloseOrderInterface();
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
        }

        private void CloseOrderInterface()
        {
            if (ParentForm is FormOrderInterface orderInterfaceForm)
            {
                orderInterfaceForm.Close();
            }
        }
    }
}
