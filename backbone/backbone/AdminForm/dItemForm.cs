using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone.AdminForm
{
    public partial class dItemForm : Form
    {
        public dItemForm()
        {
            InitializeComponent();

            formItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            formItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formItem2 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formItem3 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm.cAdmin1 form = new();
            form.Show();
            panel1.Controls.Clear();
            this.Close();
        }

    }
}
