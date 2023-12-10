﻿namespace backbone.CustomerForms
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.btnVoidOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 99);
            this.button3.TabIndex = 8;
            this.button3.Text = "Beverages";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 99);
            this.button2.TabIndex = 7;
            this.button2.Text = "Side Dishes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 99);
            this.button1.TabIndex = 6;
            this.button1.Text = "Main Dishes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(225, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 545);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 856);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "TOTAL BILL:";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBill.Location = new System.Drawing.Point(563, 847);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(225, 39);
            this.lblTotalBill.TabIndex = 30;
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoidOrder
            // 
            this.btnVoidOrder.Location = new System.Drawing.Point(174, 696);
            this.btnVoidOrder.Name = "btnVoidOrder";
            this.btnVoidOrder.Size = new System.Drawing.Size(225, 91);
            this.btnVoidOrder.TabIndex = 29;
            this.btnVoidOrder.Text = "VOID ORDER";
            this.btnVoidOrder.UseVisualStyleBackColor = true;
            this.btnVoidOrder.Click += new System.EventHandler(this.btnVoidOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(563, 696);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(225, 91);
            this.btnViewOrder.TabIndex = 28;
            this.btnViewOrder.Text = "VIEW ORDERS";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalQuantity.Location = new System.Drawing.Point(174, 847);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(225, 39);
            this.lblTotalQuantity.TabIndex = 32;
            this.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(63, 847);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 43);
            this.label3.TabIndex = 33;
            this.label3.Text = "TOTAL ITEM QUANTITY:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormOrderInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 947);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.btnVoidOrder);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrderInterface";
            this.Text = "FormOrderInterface2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label lblTotalBill;
        private Button btnVoidOrder;
        private Button btnViewOrder;
        private Label lblTotalQuantity;
        private Label label3;
    }
}