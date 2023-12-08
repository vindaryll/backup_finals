using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// dine music
namespace backbone.MiscForms
{
    public partial class LoadingScreen : Form
    {

        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        bool done = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > 800)
            {
                pictureBox1.Left = 100;
            }


            panel2.Width += 5;
            panel2.Height = 32;

            if (panel2.Width > 585)
            {
                panel2.Width = 585;
                timer1.Enabled = false;
                done = true;
            }

            if (done)
            {
                load();
            }        
        }

        private void load()
        {
            Form1 form = new();
            form.Show();
            this.Hide();
        }
    }
}
