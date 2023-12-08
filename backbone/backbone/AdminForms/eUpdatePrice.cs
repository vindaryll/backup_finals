using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class eUpdatePrice : Form
    {
        Functions func = new();
        public eUpdatePrice()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {
            func.getCurrentPrice(pv.adminItemIndex);
            lblPrice.Text = "PHP " + pv.currentPrice.ToString("N2");
            func.picture(pv.adminItemIndex, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter a Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(textBox1.Text, out price) && price >= 0)
            {
                func.updatePrice(price, pv.adminItemIndex);
                MessageBox.Show("Price Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                func.getItemInfo();
                showdata();
            }
            else
            {
                MessageBox.Show("Please Enter a valid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dItemForm form = new();
            form.Show();
            this.Close();
        }
    }
}
