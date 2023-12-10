namespace backbone.CustomerForms
{
    partial class FormOrderItem
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl5 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(83, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.increasequan;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(532, 729);
            button1.Name = "button1";
            button1.Size = new Size(69, 66);
            button1.TabIndex = 1;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.decreasequan;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(627, 729);
            button2.Name = "button2";
            button2.Size = new Size(69, 66);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl4
            // 
            lbl4.BackColor = Color.FromArgb(242, 242, 242);
            lbl4.Location = new Point(398, 738);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(82, 48);
            lbl4.TabIndex = 3;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.BackColor = Color.FromArgb(242, 242, 242);
            lbl3.Location = new Point(91, 379);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(662, 224);
            lbl3.TabIndex = 4;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.FromArgb(242, 242, 242);
            lbl1.ForeColor = Color.FromArgb(255, 49, 49);
            lbl1.Location = new Point(328, 238);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(367, 39);
            lbl1.TabIndex = 5;
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.FromArgb(242, 242, 242);
            lbl2.Location = new Point(328, 277);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(367, 39);
            lbl2.TabIndex = 6;
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl5
            // 
            lbl5.BackColor = Color.White;
            lbl5.FlatStyle = FlatStyle.Flat;
            lbl5.ForeColor = Color.FromArgb(255, 49, 49);
            lbl5.Location = new Point(424, 904);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(201, 29);
            lbl5.TabIndex = 7;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.donebtn;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(627, 986);
            button3.Name = "button3";
            button3.Size = new Size(186, 37);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormOrderItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(button3);
            Controls.Add(lbl5);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lbl3);
            Controls.Add(lbl4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrderItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderItem1";
            Load += FormOrderItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label lbl4;
        private Label lbl3;
        private Label lbl1;
        private Label lbl2;
        private Label lbl5;
        private Button button3;
    }
}