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
    public partial class aLoginForm : Form
    {
        Functions func = new Functions();
        public aLoginForm()
        {
            InitializeComponent();
            func.getAdminInfo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm.bVerification form = new();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            else
            {
                if(username == PublicVariables.username && password == PublicVariables.password)
                {
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm.cAdmin1 form = new();
                    form.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 form = new();
            form.Show();
            this.Close();
        }
    }
}
