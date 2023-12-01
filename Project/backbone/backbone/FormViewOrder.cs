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
            lblTotalBill.Text = PublicVariables.totalBill.ToString();
            lblTotalQuantity.Text = PublicVariables.totalQuantity.ToString();
        }

        private void showData()
        {
            dataGridView1.Rows.Clear();

            //pre-define since 
            //dataGridView1.Columns.Add("itemID", "ITEM ID");
            //dataGridView1.Columns.Add("itemName", "ITEM NAME");
            //dataGridView1.Columns.Add("itemQuantity", "ITEM QUANTITY");
            //dataGridView1.Columns.Add("mealTotal", "MEAL TOTAL");

            func.showItemOnDT(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrderInterface form = new FormOrderInterface();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPayment1 form = new FormPayment1();
            this.Hide();
            form.Show();
        }

        private void FormViewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
