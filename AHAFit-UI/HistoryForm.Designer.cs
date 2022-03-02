
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
            this.dgvHistoryFormDaily = new System.Windows.Forms.DataGridView();
            this.dgvHistoryFormWeekly = new System.Windows.Forms.DataGridView();
            this.dgvHistoryFormMonthly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoryFormDaily
            // 
            this.dgvHistoryFormDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryFormDaily.Location = new System.Drawing.Point(12, 62);
            this.dgvHistoryFormDaily.Name = "dgvHistoryFormDaily";
            this.dgvHistoryFormDaily.Size = new System.Drawing.Size(240, 316);
            this.dgvHistoryFormDaily.TabIndex = 0;
            // 
            // dgvHistoryFormWeekly
            // 
            this.dgvHistoryFormWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryFormWeekly.Location = new System.Drawing.Point(258, 62);
            this.dgvHistoryFormWeekly.Name = "dgvHistoryFormWeekly";
            this.dgvHistoryFormWeekly.Size = new System.Drawing.Size(240, 316);
            this.dgvHistoryFormWeekly.TabIndex = 1;
            // 
            // dgvHistoryFormMonthly
            // 
            this.dgvHistoryFormMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryFormMonthly.Location = new System.Drawing.Point(504, 62);
            this.dgvHistoryFormMonthly.Name = "dgvHistoryFormMonthly";
            this.dgvHistoryFormMonthly.Size = new System.Drawing.Size(240, 316);
            this.dgvHistoryFormMonthly.TabIndex = 2;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistoryFormMonthly);
            this.Controls.Add(this.dgvHistoryFormWeekly);
            this.Controls.Add(this.dgvHistoryFormDaily);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryFormMonthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoryFormDaily;
        private System.Windows.Forms.DataGridView dgvHistoryFormWeekly;
        private System.Windows.Forms.DataGridView dgvHistoryFormMonthly;
    }
}