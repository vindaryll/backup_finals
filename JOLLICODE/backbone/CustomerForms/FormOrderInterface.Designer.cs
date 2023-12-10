namespace backbone.CustomerForms
{
    partial class FormOrderInterface
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
            lblTotalBill = new Label();
            btnVoidOrder = new Button();
            btnViewOrder = new Button();
            lblTotalQuantity = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(204, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 644);
            panel1.TabIndex = 5;
            // 
            // lblTotalBill
            // 
            lblTotalBill.BackColor = Color.Transparent;
            lblTotalBill.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalBill.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotalBill.Location = new Point(581, 903);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(214, 32);
            lblTotalBill.TabIndex = 30;
            lblTotalBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoidOrder
            // 
            btnVoidOrder.BackgroundImage = Properties.Resources.voidbtn;
            btnVoidOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoidOrder.Cursor = Cursors.Hand;
            btnVoidOrder.FlatAppearance.BorderSize = 0;
            btnVoidOrder.FlatStyle = FlatStyle.Flat;
            btnVoidOrder.Location = new Point(26, 986);
            btnVoidOrder.Name = "btnVoidOrder";
            btnVoidOrder.Size = new Size(188, 37);
            btnVoidOrder.TabIndex = 29;
            btnVoidOrder.Text = " ";
            btnVoidOrder.UseVisualStyleBackColor = true;
            btnVoidOrder.Click += btnVoidOrder_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.BackgroundImage = Properties.Resources.vieworderbtn;
            btnViewOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewOrder.Cursor = Cursors.Hand;
            btnViewOrder.FlatAppearance.BorderSize = 0;
            btnViewOrder.FlatStyle = FlatStyle.Flat;
            btnViewOrder.Location = new Point(627, 986);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(186, 37);
            btnViewOrder.TabIndex = 28;
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.BackColor = Color.Transparent;
            lblTotalQuantity.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalQuantity.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotalQuantity.Location = new Point(195, 903);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(83, 32);
            lblTotalQuantity.TabIndex = 32;
            lblTotalQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            iconButton1.IconColor = Color.FromArgb(255, 49, 49);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 85;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(0, 325);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(148, 105);
            iconButton1.TabIndex = 33;
            iconButton1.Text = "MAIN DISH";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Hotdog;
            iconButton2.IconColor = Color.FromArgb(255, 49, 49);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 85;
            iconButton2.Location = new Point(0, 477);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(148, 105);
            iconButton2.TabIndex = 34;
            iconButton2.Text = "SIDES";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.GlassWater;
            iconButton3.IconColor = Color.FromArgb(255, 49, 49);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 85;
            iconButton3.ImageAlign = ContentAlignment.TopCenter;
            iconButton3.Location = new Point(0, 629);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(148, 105);
            iconButton3.TabIndex = 35;
            iconButton3.Text = "BEVERAGES";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // FormOrderInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Customer_Menu_Interface_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(lblTotalQuantity);
            Controls.Add(lblTotalBill);
            Controls.Add(btnVoidOrder);
            Controls.Add(btnViewOrder);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrderInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrderInterface2";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblTotalBill;
        private Button btnVoidOrder;
        private Button btnViewOrder;
        private Label lblTotalQuantity;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}