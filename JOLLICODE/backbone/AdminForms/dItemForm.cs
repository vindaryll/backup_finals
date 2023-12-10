using System.Drawing.Text;

namespace backbone.AdminForms
{
    public partial class dItemForm : Form
    {
        public dItemForm()
        {
            InitializeComponent();

            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Keith Carlo\\Downloads\\Jellee-Roman\\Jellee-Roman.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cAdmin1 form = new();
            form.Show();
            panel1.Controls.Clear();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            userFormItem2 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            userFormItem3 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }
    }
}
