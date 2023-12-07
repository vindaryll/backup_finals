using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace backbone
{
    public partial class Form0Start : Form
    {

        public Form0Start()
        {
            InitializeComponent();

            this.Hide();
            Form1 form = new();
            form.Show();
        }
    }
}
