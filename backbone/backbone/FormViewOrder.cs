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
    public partial class FormViewOrder : Form
    {
        Functions func = new Functions();
        public FormViewOrder()
        {
            InitializeComponent();
            showData();
            lblTotalBill.Text = "PHP " + PublicVariables.totalBill.ToString("N2");
            lblTotalQuantity.Text = PublicVariables.totalQuantity.ToString();
        }
        
        private void showData()
        {
            dataGridView1.Rows.Clear();

            //pre-define or p'wedeng kami na ang mag-edit
            //dataGridView1.Columns.Add("itemID", "ITEM ID");
            //dataGridView1.Columns.Add("itemName", "ITEM NAME");
            //dataGridView1.Columns.Add("itemQuantity", "ITEM QUANTITY");
            //dataGridView1.Columns.Add("mealTotal", "MEAL TOTAL");

            func.showItemOnDT(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrderInterface form = new();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPayment1 form = new FormPayment1();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_mouseclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string? itemIDString = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (int.TryParse(itemIDString, out int itemID))
                {
                    if (itemID > 0)
                    {
                        PublicVariables.indexItem = itemID - 1;
                        FormEditOrder form = new();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        // nothing to show
                    }
                }
            }
            catch
            {
                // nothing to show
            }
            
        }
    }
}
