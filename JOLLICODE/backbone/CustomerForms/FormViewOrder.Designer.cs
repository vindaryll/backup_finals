namespace backbone.CustomerForms
{
    partial class FormViewOrder
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
            dataGridView1 = new DataGridView();
            lblTotalBill = new Label();
            button1 = new Button();
            button2 = new Button();
            lblTotalQuantity = new Label();
            itemID = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            mealTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { itemID, itemName, ItemQuantity, mealTotal });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(43, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(755, 598);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_mouseclick;
            // 
            // lblTotalBill
            // 
            lblTotalBill.BackColor = Color.White;
            lblTotalBill.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotalBill.Location = new Point(581, 905);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(210, 28);
            lblTotalBill.TabIndex = 6;
            lblTotalBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.redreturnbtn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 986);
            button1.Name = "button1";
            button1.Size = new Size(188, 37);
            button1.TabIndex = 7;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.proceedtopaymentbtn;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(462, 986);
            button2.Name = "button2";
            button2.Size = new Size(352, 37);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.BackColor = Color.White;
            lblTotalQuantity.ForeColor = Color.FromArgb(255, 49, 49);
            lblTotalQuantity.Location = new Point(196, 905);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(78, 28);
            lblTotalQuantity.TabIndex = 10;
            lblTotalQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemID
            // 
            itemID.HeaderText = "ITEM ID";
            itemID.MinimumWidth = 6;
            itemID.Name = "itemID";
            itemID.Width = 123;
            // 
            // itemName
            // 
            itemName.HeaderText = "ITEM NAME";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.Width = 327;
            // 
            // ItemQuantity
            // 
            ItemQuantity.HeaderText = "QUANTITY";
            ItemQuantity.MinimumWidth = 6;
            ItemQuantity.Name = "ItemQuantity";
            ItemQuantity.Width = 152;
            // 
            // mealTotal
            // 
            mealTotal.HeaderText = "MEAL TOTAL";
            mealTotal.MinimumWidth = 6;
            mealTotal.Name = "mealTotal";
            mealTotal.Width = 152;
            // 
            // FormViewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Customer_View_Order_Interface;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(lblTotalQuantity);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTotalBill);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewOrder";
            Load += FormViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTotalBill;
        private Button button1;
        private Button button2;
        private Label lblTotalQuantity;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn mealTotal;
    }
}