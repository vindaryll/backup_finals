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
    public partial class FormReceipt : Form
    {
        Functions func = new Functions();
        public FormReceipt()
        {
            InitializeComponent();
            dataQueries();
            showData();
        }

        private void showData()
        {
            int initialTop = 50;
            int textBoxHeight = 24;
            int verticalSpacing = 24;

            for (int i = 0; i < 22; i++)
            {
                if (PublicVariables.itemQuantity[i] > 0)
                {
                    // Create Label for Item Name
                    Label itemNameLabel = new Label();
                    itemNameLabel.Text = $"{PublicVariables.itemName[i]}";
                    itemNameLabel.Location = new System.Drawing.Point(34, initialTop);
                    itemNameLabel.Size = new System.Drawing.Size(153, textBoxHeight);
                    itemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
                    panel1.Controls.Add(itemNameLabel);

                    // Create Label for Quantity
                    Label quantityLabel = new Label();
                    quantityLabel.Text = $"{PublicVariables.itemQuantity[i]}";
                    quantityLabel.Location = new System.Drawing.Point(401, initialTop);
                    quantityLabel.Size = new System.Drawing.Size(69, textBoxHeight);
                    quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
                    panel1.Controls.Add(quantityLabel);

                    // Create Label for Subprice
                    Label subpriceLabel = new Label();
                    subpriceLabel.Text = $"{PublicVariables.mealTotal[i]}";
                    subpriceLabel.Location = new System.Drawing.Point(531, initialTop);
                    subpriceLabel.Size = new System.Drawing.Size(69, textBoxHeight);
                    subpriceLabel.TextAlign = ContentAlignment.MiddleCenter;
                    panel1.Controls.Add(subpriceLabel);

                    // Adjust the initialTop for the next set of Labels
                    initialTop += verticalSpacing;
                }
            }

            lblOrderID.Text = PublicVariables.orderID.ToString();
            lblName.Text = PublicVariables.customerName.ToString();
            lblAddress.Text = PublicVariables.customerAddress.ToString();
            lblPhone.Text = PublicVariables.customerContact.ToString();
            lblDate.Text = PublicVariables.date;
            lblMop.Text = PublicVariables.paymentMethod;
            lblTotal.Text = PublicVariables.totalBill.ToString("N2");
            lblPayment.Text = PublicVariables.paymentAmount.ToString("N2");
            lblChange.Text = PublicVariables.changeAmount.ToString("N2");

        }

        private void dataQueries()
        {
            // Insert Customer
            func.getCustomerID(PublicVariables.customerName, PublicVariables.customerContact);
            if (PublicVariables.isNewCustomer)
            {
                func.InsertCustomers(PublicVariables.customerName, PublicVariables.customerContact, PublicVariables.customerAddress);
                func.refreshCustomer();
            }
            // Insert Order
            func.getOrderID();
            func.InsertOrders(PublicVariables.customerID, PublicVariables.paymentMethod);
            func.refreshOrders();
            // Insert Transaction
            func.InsertOrderTransaction(PublicVariables.orderID, PublicVariables.totalBill, PublicVariables.paymentAmount, PublicVariables.changeAmount);
            func.refreshOrderTransaction();
            //Insert OrderItem
            for (int i = 0; i < 22; i++)
            {
                if (PublicVariables.itemQuantity[i] > 0)
                {
                    func.InsertOrderItem(PublicVariables.orderID, PublicVariables.itemID[i], PublicVariables.itemQuantity[i], PublicVariables.mealTotal[i]);
                }

            }
            func.refreshOrderItem();
            // getting date
            func.getDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func.VarReset();
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
