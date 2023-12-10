namespace backbone.CustomerForms
{
    partial class FormReceipt
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
            panel1 = new Panel();
            lblOrderID = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblDate = new Label();
            lblMop = new Label();
            lblTotal = new Label();
            lblPayment = new Label();
            lblChange = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(63, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 296);
            panel1.TabIndex = 4;
            // 
            // lblOrderID
            // 
            lblOrderID.BackColor = Color.White;
            lblOrderID.ForeColor = Color.FromArgb(255, 49, 49);
            lblOrderID.Location = new Point(211, 170);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(171, 30);
            lblOrderID.TabIndex = 10;
            lblOrderID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.ForeColor = Color.FromArgb(255, 49, 49);
            lblName.Location = new Point(172, 217);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 30);
            lblName.TabIndex = 11;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.White;
            lblAddress.ForeColor = Color.FromArgb(255, 49, 49);
            lblAddress.Location = new Point(211, 250);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(387, 30);
            lblAddress.TabIndex = 12;
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.White;
            lblPhone.ForeColor = Color.FromArgb(255, 49, 49);
            lblPhone.Location = new Point(604, 217);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(164, 30);
            lblPhone.TabIndex = 13;
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.White;
            lblDate.ForeColor = Color.FromArgb(255, 49, 49);
            lblDate.Location = new Point(82, 687);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(363, 30);
            lblDate.TabIndex = 14;
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMop
            // 
            lblMop.BackColor = Color.White;
            lblMop.ForeColor = Color.FromArgb(255, 49, 49);
            lblMop.Location = new Point(585, 653);
            lblMop.Name = "lblMop";
            lblMop.Size = new Size(174, 30);
            lblMop.TabIndex = 15;
            lblMop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotal.Location = new Point(585, 687);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 30);
            lblTotal.TabIndex = 16;
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPayment
            // 
            lblPayment.BackColor = Color.White;
            lblPayment.ForeColor = Color.FromArgb(255, 49, 49);
            lblPayment.Location = new Point(281, 743);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(164, 30);
            lblPayment.TabIndex = 17;
            lblPayment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChange
            // 
            lblChange.BackColor = Color.White;
            lblChange.ForeColor = Color.FromArgb(255, 49, 49);
            lblChange.Location = new Point(585, 743);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(174, 30);
            lblChange.TabIndex = 18;
            lblChange.TextAlign = ContentAlignment.MiddleLeft;
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
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Customer_Receipt_Interface;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(button1);
            Controls.Add(lblChange);
            Controls.Add(lblPayment);
            Controls.Add(lblTotal);
            Controls.Add(lblMop);
            Controls.Add(lblDate);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblOrderID);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReceipt";
            Load += FormReceipt_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblOrderID;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblDate;
        private Label lblMop;
        private Label lblTotal;
        private Label lblPayment;
        private Label lblChange;
        private Button button1;
    }
}