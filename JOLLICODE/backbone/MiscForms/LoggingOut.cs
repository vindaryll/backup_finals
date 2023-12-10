using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone.MiscForms
{
    public partial class LoggingOut : Form
    {
        private int dotsCount = 1;
        public LoggingOut()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dots = new string('.', dotsCount);

            if (LogoutComplete())
            {
                label1.Text = "LOGGED OUT!";
                timer1.Stop();
                this.Close();
                Form1 form = new();
                form.Show();
            }
            else
            {
                label1.Text = $"LOGGING OUT{dots}";
            }

            dotsCount++;
        }

        private bool LogoutComplete()
        {
            return dotsCount == 4; // out of range
        }

        private void LoggingOut_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            }
        }
    }
}
