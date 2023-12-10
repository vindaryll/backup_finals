using System.Drawing.Text;

namespace backbone.MiscForms
{
    public partial class ShuttingDown : Form
    {
        private int dotsCount = 1;

        public ShuttingDown()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dots = new string('.', dotsCount);

            if (ShutdownComplete())
            {
                timer1.Stop();
                Application.Exit();
            }
            else
            {
                label1.Text = $"SHUTTING DOWN{dots}";
            }

            dotsCount++;
        }
        private bool ShutdownComplete()
        {
            return dotsCount == 4; // out of range
        }
    }
}
