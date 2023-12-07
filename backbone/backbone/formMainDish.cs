﻿using pv = backbone.PublicVariables;

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

                if (button != null && i < pv.itemName.Length)
                {
                    button.Text = pv.itemName[i];
                }
            }

            // image
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            func.mainDishBtns(buttons);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            pv.indexItem = 0;
            isAvailable(pv.indexItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.indexItem = 1;
            isAvailable(pv.indexItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pv.indexItem = 2;
            isAvailable(pv.indexItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pv.indexItem = 3;
            isAvailable(pv.indexItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pv.indexItem = 4;
            isAvailable(pv.indexItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pv.indexItem = 5;
            isAvailable(pv.indexItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pv.indexItem = 6;
            isAvailable(pv.indexItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pv.indexItem = 7;
            isAvailable(pv.indexItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pv.indexItem = 8;
            isAvailable(pv.indexItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pv.indexItem = 9;
            isAvailable(pv.indexItem);
        }


        private void isAvailable(int index)
        {
            if (pv.itemAvailability[index])
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
