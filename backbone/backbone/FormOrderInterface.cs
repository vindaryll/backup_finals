using backbone.AdminForm;
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
    public partial class FormOrderInterface : Form
    {
        Functions func = new();
        public FormOrderInterface()
        {
            InitializeComponent();
            lblTotalBill.Text = PublicVariables.totalBill.ToString("N2");

            panel1.Controls.Clear();
            formMainDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            formMainDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formSideDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formBeverage form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }


        private void btnVoidOrder_Click(object sender, EventArgs e)
        {
            func.VarReset();
            Form1 form = new Form1();
            MessageBox.Show("ORDER'S SUCCESSFULLY CANCELED");
            form.Show();
            this.Close();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (PublicVariables.totalBill <= 0)
            {
                // nothing to show
            }
            else
            {
                FormViewOrder oi = new FormViewOrder();
                this.Hide();
                oi.Show();
            }
        }
    }
}
