namespace backbone
{
    public partial class Form1 : Form
    {
        Functions func = new Functions();
        public Form1()
        {
            InitializeComponent();
            func.refreshCustomer();
            func.refreshOrders();
            func.refreshOrderTransaction();
            func.refreshOrderItem();
            func.getItemInfo();
        }

        private void Form1_click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            this.Hide();
            f2.ShowDialog();
        }

    }
}