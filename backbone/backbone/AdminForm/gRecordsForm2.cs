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
    public partial class gRecordsForm2 : Form
    {
        Functions func = new();
        public gRecordsForm2()
        {
            InitializeComponent();
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicVariables.orderID = 0; // to reset the orderID when clicking return
            this.Close();
            fRecordsForm1 form = new();
            form.Show();

        }
        private void showData()
        {
            // string query = $"SELECT i.ItemID, i.ItemName, oi.Quantity, oi.MealTotal\r\nFROM Item AS i\r\nJOIN OrderItem AS oi ON oi.ItemID = i.ItemID\r\nJOIN Orders AS o ON o.OrderID = oi.OrderID\r\nWHERE o.OrderID = {PublicVariables.orderID} \r\nGROUP BY i.ItemName, oi.Quantity, oi.MealTotal \r\nORDER BY i.ItemID";

            // func.Displaydata(dataGridView1, query);
            func.getDataForView();
            int initialTop = 59;
            int textBoxHeight = 31;
            int verticalSpacing = 31;

            for (int i = 0; i < pv.record_itemID.Length;  i++)
            {
                // Create Label for Item ID
                Label itemIDLabel = new Label();
                itemIDLabel.Text = $"{pv.record_itemID[i]}";
                itemIDLabel.Location = new System.Drawing.Point(22, initialTop);
                itemIDLabel.Size = new System.Drawing.Size(105, textBoxHeight);
                itemIDLabel.TextAlign = ContentAlignment.MiddleCenter;
                panel1.Controls.Add(itemIDLabel);

                // Create Label for Item Name
                Label itemNameLabel = new Label();
                itemNameLabel.Text = $"{pv.record_itemName[i]}";
                itemNameLabel.Location = new System.Drawing.Point(139, initialTop);
                itemNameLabel.Size = new System.Drawing.Size(260, textBoxHeight);
                itemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                panel1.Controls.Add(itemNameLabel);

                // Create Label for Quantity
                Label quantityLabel = new Label();
                quantityLabel.Text = $"{pv.record_quantity[i]}";
                quantityLabel.Location = new System.Drawing.Point(447, initialTop);
                quantityLabel.Size = new System.Drawing.Size(105, textBoxHeight);
                quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
                panel1.Controls.Add(quantityLabel);

                // Create Label for Meal Total
                Label mealTotalLabel = new Label();
                mealTotalLabel.Text = pv.record_quantity[i].ToString("N2");
                mealTotalLabel.Location = new System.Drawing.Point(587, initialTop);
                mealTotalLabel.Size = new System.Drawing.Size(105, textBoxHeight);
                mealTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
                panel1.Controls.Add(mealTotalLabel);

                initialTop += verticalSpacing;
            }

            lblTotal.Text = "PHP " + PublicVariables.totalBill.ToString("N2");
            lblPayment.Text = "PHP " + PublicVariables.paymentAmount.ToString("N2");
            lblChange.Text = "PHP " + PublicVariables.changeAmount.ToString("N2") ;
            lblCustomerID.Text = PublicVariables.customerID.ToString();
            lblName.Text = PublicVariables.customerName.ToString();
            lblContact.Text = PublicVariables.customerContact.ToString();
            lblAddress.Text = PublicVariables.customerAddress.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void disable_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

    }
}
