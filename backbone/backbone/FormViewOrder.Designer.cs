namespace backbone
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.ItemQuantity,
            this.mealTotal});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(52, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_mouseclick);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ITEM ID";
            this.itemID.MinimumWidth = 6;
            this.itemID.Name = "itemID";
            this.itemID.Width = 97;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "ITEM NAME";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 350;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "QUANTITY";
            this.ItemQuantity.MinimumWidth = 6;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 189;
            // 
            // mealTotal
            // 
            this.mealTotal.HeaderText = "MEAL TOTAL";
            this.mealTotal.MinimumWidth = 6;
            this.mealTotal.Name = "mealTotal";
            this.mealTotal.Width = 189;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBill.Location = new System.Drawing.Point(721, 436);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(176, 39);
            this.lblTotalBill.TabIndex = 6;
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 78);
            this.button2.TabIndex = 8;
            this.button2.Text = "PROCEED TO PAYMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalQuantity.Location = new System.Drawing.Point(539, 436);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(176, 39);
            this.lblTotalQuantity.TabIndex = 10;
            this.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 658);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormViewOrder";
            this.Text = "FormViewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label lblTotalBill;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn mealTotal;
        private Label lblTotalQuantity;
    }
}