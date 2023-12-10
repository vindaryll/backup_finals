using System.Drawing.Text;

namespace backbone.MiscForms
{
    public partial class ReceiptLoading : Form
    {
        private int dotsCount = 1;
        public ReceiptLoading()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 36, FontStyle.Regular);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dots = new string('.', dotsCount);

            if (printed())
            {
                timer1.Stop();
                CustomerForms.FormReceipt form = new();
                form.Show();
                this.Close();
            }
            else
            {
                label1.Text = $"PRINTING RECEIPT{dots}";
            }

            dotsCount++;
        }
        private bool printed()
        {
            return dotsCount == 4; // out of range
        }
    }
}
