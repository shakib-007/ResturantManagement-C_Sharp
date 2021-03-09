
namespace ResturantManagement
{
    partial class FormOrderId
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.currDate = new System.Windows.Forms.DateTimePicker();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordered_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Table_ID,
            this.Ordered_on});
            this.dgvOrderDetail.Location = new System.Drawing.Point(30, 141);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(445, 303);
            this.dgvOrderDetail.TabIndex = 1;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            // 
            // currDate
            // 
            this.currDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currDate.Location = new System.Drawing.Point(657, 200);
            this.currDate.Name = "currDate";
            this.currDate.Size = new System.Drawing.Size(200, 22);
            this.currDate.TabIndex = 2;
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(657, 141);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(200, 22);
            this.txtTableId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Table Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ordered On :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(631, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(521, 354);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(752, 421);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(124, 23);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // Order_ID
            // 
            this.Order_ID.DataPropertyName = "Order_ID";
            this.Order_ID.HeaderText = "Order_ID";
            this.Order_ID.MinimumWidth = 6;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Width = 125;
            // 
            // Table_ID
            // 
            this.Table_ID.DataPropertyName = "Table_ID";
            this.Table_ID.HeaderText = "Table_ID";
            this.Table_ID.MinimumWidth = 6;
            this.Table_ID.Name = "Table_ID";
            this.Table_ID.Width = 125;
            // 
            // Ordered_on
            // 
            this.Ordered_on.DataPropertyName = "Ordered_on";
            this.Ordered_on.HeaderText = "Ordered_on";
            this.Ordered_on.MinimumWidth = 6;
            this.Ordered_on.Name = "Ordered_on";
            this.Ordered_on.Width = 125;
            // 
            // FormOrderId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.currDate);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnBack);
            this.Name = "FormOrderId";
            this.Text = "GenarateOrderId";
            this.Load += new System.EventHandler(this.FormOrderId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DateTimePicker currDate;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordered_on;
    }
}