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
    public partial class fRecordsForm1 : Form
    {
        Functions func = new();
        public fRecordsForm1()
        {
            InitializeComponent();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            cAdmin1 form = new();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT o.OrderID, c.CustomerName, o.OrderTime AS Date, o.PaymentMethod\r\nFROM Customer AS c\r\nJOIN Orders AS o ON c.CustomerID = o.CustomerID\r\nJOIN OrderItem AS oi ON o.OrderID = oi.OrderID\r\nJOIN OrderTransaction as ot ON ot.OrderID = o.OrderID\r\nWHERE c.CustomerName LIKE '{textBox1.Text}%'\r\nGROUP BY o.OrderID, c.customerName\r\nORDER BY Date";
            func.Displaydata(dataGridView1, query);
        }

        private void refresh()
        {
            string query = "SELECT o.OrderID, c.CustomerName, o.OrderTime AS Date, o.PaymentMethod\r\nFROM Customer AS c\r\nJOIN Orders AS o ON c.CustomerID = o.CustomerID\r\nJOIN OrderItem AS oi ON o.OrderID = oi.OrderID\r\nJOIN OrderTransaction as ot ON ot.OrderID = o.OrderID\r\nGROUP BY o.OrderID, c.customerName\r\nORDER BY Date";
            func.Displaydata(dataGridView1, query);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string? orderIDString = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (int.TryParse(orderIDString, out int orderID))
            {

                PublicVariables.orderID = orderID;
                func.getRecordsInfo();
            }
            else
            {
                PublicVariables.orderID = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PublicVariables.orderID == 0) 
            {
                // nothing to show
            }
            else
            {
                gRecordsForm2 form = new();
                form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PublicVariables.orderID == 0)
            {
                // nothing to show
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Order no. {PublicVariables.orderID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed deletion
                    func.deleteRecords();
                    func.deleteCustomer(); // Delete customer if no records in orders
                    func.refreshCustomer();
                    func.refreshOrderItem();
                    func.refreshOrderTransaction();
                    func.refreshOrders();
                    MessageBox.Show($"Order no. {PublicVariables.orderID} has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PublicVariables.orderID = 0;
                }
                // If the user clicks "No", do nothing

            }
        }
    }
}
