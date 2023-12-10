namespace backbone.CustomerForms
{
    partial class FormEditOrder
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
            button3 = new Button();
            lblMealTotal = new Label();
            lblPrice = new Label();
            lblItemName = new Label();
            lblQuantity = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.redreturnbtn;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(23, 986);
            button3.Name = "button3";
            button3.Size = new Size(188, 37);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblMealTotal
            // 
            lblMealTotal.BackColor = Color.FromArgb(242, 242, 242);
            lblMealTotal.Location = new Point(382, 851);
            lblMealTotal.Name = "lblMealTotal";
            lblMealTotal.Size = new Size(367, 48);
            lblMealTotal.TabIndex = 18;
            lblMealTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.FromArgb(242, 242, 242);
            lblPrice.FlatStyle = FlatStyle.Flat;
            lblPrice.Location = new Point(382, 447);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(253, 39);
            lblPrice.TabIndex = 17;
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.FromArgb(242, 242, 242);
            lblItemName.FlatStyle = FlatStyle.Flat;
            lblItemName.ForeColor = Color.FromArgb(255, 49, 49);
            lblItemName.Location = new Point(382, 367);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(367, 39);
            lblItemName.TabIndex = 16;
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.FromArgb(242, 242, 242);
            lblQuantity.Location = new Point(348, 693);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(145, 68);
            lblQuantity.TabIndex = 14;
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.decreasequan;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(573, 693);
            button2.Name = "button2";
            button2.Size = new Size(68, 68);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.increasequan;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(199, 690);
            button1.Name = "button1";
            button1.Size = new Size(68, 68);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(88, 357);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormEditOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Customer_Edit_Order_Interface;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(button3);
            Controls.Add(lblMealTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblItemName);
            Controls.Add(lblQuantity);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditOrder";
            Load += FormEditOrder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Label lblMealTotal;
        private Label lblPrice;
        private Label lblItemName;
        private Label lblQuantity;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}