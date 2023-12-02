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
    public partial class formMainDish : UserControl
    {
        Functions func = new();
        public formMainDish()
        {
            InitializeComponent();
            getBtnInfo();
        }

        private void getBtnInfo()
        {
            // names
            for (int i = 0; i < 10; i++)
            {
                var button = this.Controls.Find($"button{i + 1}", true).FirstOrDefault() as Button;

                if (button != null && i < PublicVariables.itemName.Length)
                {
                    button.Text = PublicVariables.itemName[i];
                }
            }

            // image
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            func.mainDishBtns(buttons);
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



        // to close parent form
        private void CloseOrderInterface()
        {
            if (ParentForm is FormOrderInterface orderInterfaceForm)
            {
                orderInterfaceForm.Close();
            }
        }


    }
}
