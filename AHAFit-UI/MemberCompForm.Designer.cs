
namespace AHAFit_UI
{
    partial class MemberCompForm
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
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCompare = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWeekly
            // 
            this.btnWeekly.Location = new System.Drawing.Point(54, 37);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(179, 97);
            this.btnWeekly.TabIndex = 2;
            this.btnWeekly.Text = "Weekly Comparison";
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Location = new System.Drawing.Point(250, 37);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(179, 97);
            this.btnMonthly.TabIndex = 2;
            this.btnMonthly.Text = "Monthly Comparison";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(447, 37);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(179, 97);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All Time Comparison";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calorie Champ User:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(259, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(226, 29);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Select Time Interval";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 94);
            this.panel1.TabIndex = 4;
            // 
            // dgvCompare
            // 
            this.dgvCompare.AllowUserToAddRows = false;
            this.dgvCompare.AllowUserToDeleteRows = false;
            this.dgvCompare.AllowUserToResizeColumns = false;
            this.dgvCompare.AllowUserToResizeRows = false;
            this.dgvCompare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompare.Location = new System.Drawing.Point(5, 271);
            this.dgvCompare.Name = "dgvCompare";
            this.dgvCompare.ReadOnly = true;
            this.dgvCompare.RowHeadersVisible = false;
            this.dgvCompare.RowHeadersWidth = 92;
            this.dgvCompare.RowTemplate.Height = 37;
            this.dgvCompare.Size = new System.Drawing.Size(2040, 710);
            this.dgvCompare.TabIndex = 5;
            // 
            // MemberCompForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2057, 993);
            this.Controls.Add(this.dgvCompare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnWeekly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberCompForm";
            this.Text = "MemberCompForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCompare;
    }
}