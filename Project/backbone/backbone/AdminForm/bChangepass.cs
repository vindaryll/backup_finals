﻿using System;
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
    public partial class bChangepass : Form
    {
        Functions func = new();
        public bChangepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            string pass2 = textBox2.Text;

            if(string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Please fill out everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(pass == pass2)
                {
                    func.updatePass(pass);
                    MessageBox.Show("The password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AdminForm.aLoginForm form = new();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }
    }
}
