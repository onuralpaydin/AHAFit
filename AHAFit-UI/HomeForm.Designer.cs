
namespace AHAFit_UI
{
    partial class HomeForm
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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnMemberComp = new System.Windows.Forms.Button();
            this.btnFoodSt = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(93, 78);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(158, 69);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(320, 78);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(158, 69);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnMemberComp
            // 
            this.btnMemberComp.Location = new System.Drawing.Point(547, 78);
            this.btnMemberComp.Name = "btnMemberComp";
            this.btnMemberComp.Size = new System.Drawing.Size(158, 69);
            this.btnMemberComp.TabIndex = 0;
            this.btnMemberComp.Text = "Member Comparisons";
            this.btnMemberComp.UseVisualStyleBackColor = true;
            this.btnMemberComp.Click += new System.EventHandler(this.btnMemberComp_Click);
            // 
            // btnFoodSt
            // 
            this.btnFoodSt.Location = new System.Drawing.Point(774, 78);
            this.btnFoodSt.Name = "btnFoodSt";
            this.btnFoodSt.Size = new System.Drawing.Size(158, 69);
            this.btnFoodSt.TabIndex = 0;
            this.btnFoodSt.Text = "Food Statistics";
            this.btnFoodSt.UseVisualStyleBackColor = true;
            this.btnFoodSt.Click += new System.EventHandler(this.btnFoodSt_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(1001, 78);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(158, 69);
            this.btnBMI.TabIndex = 0;
            this.btnBMI.Text = "BMI Calculator";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 1037);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnFoodSt);
            this.Controls.Add(this.btnMemberComp);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnReports);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnMemberComp;
        private System.Windows.Forms.Button btnFoodSt;
        private System.Windows.Forms.Button btnBMI;
    }
}