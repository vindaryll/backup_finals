namespace backbone.CustomerForms
{
    partial class FormPaymentCash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotal = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(242, 242, 242);
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotal.Location = new Point(165, 606);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(515, 44);
            lblTotal.TabIndex = 3;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 242);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(255, 49, 49);
            textBox1.Location = new Point(165, 759);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(515, 36);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.greenproceedbtn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(628, 985);
            button1.Name = "button1";
            button1.Size = new Size(183, 38);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.redreturnbtn;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(23, 985);
            button2.Name = "button2";
            button2.Size = new Size(188, 39);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormPaymentCash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._37;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblTotal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPaymentCash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPaymentCash";
            Load += FormPaymentCash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotal;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}