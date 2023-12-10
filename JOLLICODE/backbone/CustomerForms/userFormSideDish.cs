﻿using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class userFormSideDish : UserControl
    {
        Functions func = new();
        public userFormSideDish()
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

                if (button != null && i < pv.itemName.Length)
                {
                    button.Text = pv.itemName[i];
                }
            }

            // image
            Button[] buttons = { button1, button2, button3, button4, button5 };
            func.sideDishBtns(buttons);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pv.indexItem = 10;
            isAvailable(pv.indexItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.indexItem = 11;
            isAvailable(pv.indexItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pv.indexItem = 12;
            isAvailable(pv.indexItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pv.indexItem = 13;
            isAvailable(pv.indexItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pv.indexItem = 14;
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
            FormOrderItem form = new();
            form.Show();
        }

        private void CloseOrderInterface()
        {
            if (ParentForm is FormOrderInterface parent)
            {
                parent.Close();
            }
        }

        private void userFormSideDish_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            }
        }
    }
}
