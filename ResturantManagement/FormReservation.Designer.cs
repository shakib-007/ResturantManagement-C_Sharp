
namespace ResturantManagement
{
    partial class FormReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtReserveId = new System.Windows.Forms.TextBox();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.currDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Table_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Re_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserve_For = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raserve_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserve_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserved_On = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(925, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Id";
            // 
            // txtReserveId
            // 
            this.txtReserveId.Location = new System.Drawing.Point(1074, 84);
            this.txtReserveId.Name = "txtReserveId";
            this.txtReserveId.Size = new System.Drawing.Size(200, 22);
            this.txtReserveId.TabIndex = 2;
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Re_ID,
            this.TableId,
            this.Reserve_For,
            this.Phone_No,
            this.Raserve_Date,
            this.Reserve_Time,
            this.Reserved_On});
            this.dgvReservation.Location = new System.Drawing.Point(12, 68);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(895, 276);
            this.dgvReservation.TabIndex = 3;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_ID,
            this.Seats,
            this.TableName});
            this.dgvTableInfo.Location = new System.Drawing.Point(12, 393);
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.RowHeadersWidth = 51;
            this.dgvTableInfo.RowTemplate.Height = 24;
            this.dgvTableInfo.Size = new System.Drawing.Size(429, 237);
            this.dgvTableInfo.TabIndex = 4;
            this.dgvTableInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(1074, 141);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(200, 22);
            this.txtTableId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(974, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1074, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(988, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(1074, 246);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(917, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(995, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reserve Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(934, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Current Date";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(1074, 296);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 17;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(998, 6);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(123, 27);
            this.time.TabIndex = 18;
            this.time.Value = new System.DateTime(2021, 1, 2, 15, 56, 18, 0);
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // currDate
            // 
            this.currDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currDate.Location = new System.Drawing.Point(1074, 425);
            this.currDate.Name = "currDate";
            this.currDate.Size = new System.Drawing.Size(200, 22);
            this.currDate.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(1030, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 52);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(402, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reservation Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(181, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Table Info";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Teal;
            this.btnRemove.Location = new System.Drawing.Point(1165, 536);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 52);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Teal;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(887, 536);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 52);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Table_ID
            // 
            this.Table_ID.DataPropertyName = "Table_ID";
            this.Table_ID.HeaderText = "Table_ID";
            this.Table_ID.MinimumWidth = 6;
            this.Table_ID.Name = "Table_ID";
            this.Table_ID.Width = 125;
            // 
            // Seats
            // 
            this.Seats.DataPropertyName = "Seats";
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 6;
            this.Seats.Name = "Seats";
            this.Seats.Width = 125;
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "Table Name";
            this.TableName.HeaderText = "TableName";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            this.TableName.Visible = false;
            this.TableName.Width = 125;
            // 
            // Re_ID
            // 
            this.Re_ID.DataPropertyName = "Re_ID";
            this.Re_ID.HeaderText = "Re_ID";
            this.Re_ID.MinimumWidth = 6;
            this.Re_ID.Name = "Re_ID";
            this.Re_ID.Width = 125;
            // 
            // TableId
            // 
            this.TableId.DataPropertyName = "Table_ID";
            this.TableId.HeaderText = "Table_ID";
            this.TableId.MinimumWidth = 6;
            this.TableId.Name = "TableId";
            this.TableId.Width = 125;
            // 
            // Reserve_For
            // 
            this.Reserve_For.DataPropertyName = "Reserve_For(Name)";
            this.Reserve_For.HeaderText = "Name";
            this.Reserve_For.MinimumWidth = 6;
            this.Reserve_For.Name = "Reserve_For";
            this.Reserve_For.Width = 125;
            // 
            // Phone_No
            // 
            this.Phone_No.DataPropertyName = "Phone_No.";
            this.Phone_No.HeaderText = "Phone_No";
            this.Phone_No.MinimumWidth = 6;
            this.Phone_No.Name = "Phone_No";
            this.Phone_No.Width = 125;
            // 
            // Raserve_Date
            // 
            this.Raserve_Date.DataPropertyName = "Raserve_Date";
            this.Raserve_Date.HeaderText = "Reserve_Date";
            this.Raserve_Date.MinimumWidth = 6;
            this.Raserve_Date.Name = "Raserve_Date";
            this.Raserve_Date.Width = 125;
            // 
            // Reserve_Time
            // 
            this.Reserve_Time.DataPropertyName = "Reserve_Time";
            this.Reserve_Time.HeaderText = "Reserve_Time";
            this.Reserve_Time.MinimumWidth = 6;
            this.Reserve_Time.Name = "Reserve_Time";
            this.Reserve_Time.Width = 125;
            // 
            // Reserved_On
            // 
            this.Reserved_On.DataPropertyName = "Reserved_On";
            this.Reserved_On.HeaderText = "Reserved_On";
            this.Reserved_On.MinimumWidth = 6;
            this.Reserved_On.Name = "Reserved_On";
            this.Reserved_On.Width = 125;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(1074, 357);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 22);
            this.txtTime.TabIndex = 26;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1301, 642);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.currDate);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTableInfo);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.txtReserveId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReserveId;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.DateTimePicker currDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Re_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserve_For;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raserve_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserve_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserved_On;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.TextBox txtTime;
    }
}