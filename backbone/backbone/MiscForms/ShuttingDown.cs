using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone.MiscForms
{
    public partial class ShuttingDown : Form
    {
        private int dotsCount = 1;

        public ShuttingDown()
        {
            InitializeComponent();
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
