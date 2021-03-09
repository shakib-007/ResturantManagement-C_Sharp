
namespace ResturantManagement
{
    partial class FormHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Teal;
            this.btnOrder.Location = new System.Drawing.Point(65, 306);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 61);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.Teal;
            this.btnRes.Location = new System.Drawing.Point(238, 306);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(149, 61);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "Reserve Table";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.Teal;
            this.btnEmp.Location = new System.Drawing.Point(457, 306);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(185, 61);
            this.btnEmp.TabIndex = 3;
            this.btnEmp.Text = "Employee Management";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.Location = new System.Drawing.Point(705, 306);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 61);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.Location = new System.Drawing.Point(-2, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 59);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(973, 547);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogout;
    }
}