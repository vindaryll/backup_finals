using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class FormOrderInterface : Form
    {
        Functions func = new();
        public FormOrderInterface()
        {
            InitializeComponent();
            showData();
        }

        private void showData()
        {
            lblTotalBill.Text = "PHP " + pv.totalBill.ToString("N2");
            lblTotalQuantity.Text = pv.totalQuantity.ToString();

            panel1.Controls.Clear();
            userFormMainDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            userFormMainDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            userFormSideDish form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            userFormBeverage form = new();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.BringToFront();
        }


        private void btnVoidOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you wanna void this order, {pv.customerName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                func.VarReset();
                MiscForms.CancelOrder form = new();
                form.Show();
                this.Close();
            }
            // do nothing if the user clicks "no"
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (pv.totalBill <= 0)
            {
                MessageBox.Show("no orders have been placed yet.", "Empty tray", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormViewOrder form = new();
                this.Close();
                form.Show();
            }
        }
    }
}
