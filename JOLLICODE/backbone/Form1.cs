namespace backbone
{
    public partial class Form1 : Form
    {

        Functions func = new();

        public Form1()
        {
            InitializeComponent();
            func.refreshCustomer();
            func.refreshOrders();
            func.refreshOrderTransaction();
            func.refreshOrderItem();
            func.VarReset();
            func.getItemInfo();
        }

        private void Form1_click(object sender, EventArgs e)
        {
            form2 form = new();
            form.Show();
            this.Close();
        }
    }
}