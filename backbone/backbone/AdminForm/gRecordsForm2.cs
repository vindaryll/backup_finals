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
            string query = $"SELECT i.ItemName, oi.Quantity, oi.MealTotal\r\nFROM Item AS i\r\nJOIN OrderItem AS oi ON oi.ItemID = i.ItemID\r\nJOIN Orders AS o ON o.OrderID = oi.OrderID\r\nWHERE o.OrderID = {PublicVariables.orderID} \r\nGROUP BY i.ItemName, oi.Quantity, oi.MealTotal";
            func.Displaydata(dataGridView1, query);
            lblTotal.Text = "PHP " + PublicVariables.totalBill.ToString("N2");
            lblPayment.Text = "PHP " + PublicVariables.paymentAmount.ToString("N2");
            lblChange.Text = "PHP " + PublicVariables.changeAmount.ToString("N2") ;
            lblCustomerID.Text = PublicVariables.customerID.ToString();
            lblName.Text = PublicVariables.customerName.ToString();
            lblContact.Text = PublicVariables.customerContact.ToString();
            lblAddress.Text = PublicVariables.customerAddress.ToString();
        }
    }
}
