
namespace AHAFit_UI
{
    partial class HistoryForm
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
            this.dgvHistoryFormWeekly = new System.Windows.Forms.DataGridView();
            this.dgvHistoryFormMonthly = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHistoryFormMonth = new System.Windows.Forms.Label();
            this.dtpHistoryFormMonthly = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoryFormWeekly
            // 
            this.dgvHistoryFormWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryFormWeekly.Location = new System.Drawing.Point(60, 87);
            this.dgvHistoryFormWeekly.Name = "dgvHistoryFormWeekly";
            this.dgvHistoryFormWeekly.Size = new System.Drawing.Size(240, 280);
            this.dgvHistoryFormWeekly.TabIndex = 1;
            // 
            // dgvHistoryFormMonthly
            // 
            this.dgvHistoryFormMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryFormMonthly.Location = new System.Drawing.Point(349, 87);
            this.dgvHistoryFormMonthly.Name = "dgvHistoryFormMonthly";
            this.dgvHistoryFormMonthly.Size = new System.Drawing.Size(240, 280);
            this.dgvHistoryFormMonthly.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "This Week";
            // 
            // lblHistoryFormMonth
            // 
            this.lblHistoryFormMonth.AutoSize = true;
            this.lblHistoryFormMonth.Location = new System.Drawing.Point(346, 23);
            this.lblHistoryFormMonth.Name = "lblHistoryFormMonth";
            this.lblHistoryFormMonth.Size = new System.Drawing.Size(154, 13);
            this.lblHistoryFormMonth.TabIndex = 4;
            this.lblHistoryFormMonth.Text = "Please Select a month number.";
            // 
            // dtpHistoryFormMonthly
            // 
            this.dtpHistoryFormMonthly.Location = new System.Drawing.Point(348, 43);
            this.dtpHistoryFormMonthly.Name = "dtpHistoryFormMonthly";
            this.dtpHistoryFormMonthly.Size = new System.Drawing.Size(200, 20);
            this.dtpHistoryFormMonthly.TabIndex = 7;
            this.dtpHistoryFormMonthly.ValueChanged += new System.EventHandler(this.dtpHistoryFormMonthly_ValueChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.dtpHistoryFormMonthly);
            this.Controls.Add(this.lblHistoryFormMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistoryFormMonthly);
            this.Controls.Add(this.dgvHistoryFormWeekly);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormMonthly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistoryFormWeekly;
        private System.Windows.Forms.DataGridView dgvHistoryFormMonthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHistoryFormMonth;
        private System.Windows.Forms.DateTimePicker dtpHistoryFormMonthly;
    }
}