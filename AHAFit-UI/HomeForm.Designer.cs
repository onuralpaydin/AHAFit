
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
            this.dtpHomeDate = new System.Windows.Forms.DateTimePicker();
            this.lblSumCalorie = new System.Windows.Forms.Label();
            this.lblRemainCalorie = new System.Windows.Forms.Label();
            this.lblRemainWater = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCarbo = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnAteSomething = new System.Windows.Forms.Button();
            this.btnProgramChanger = new System.Windows.Forms.Button();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.dgvDailyFoodList = new System.Windows.Forms.DataGridView();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMealSumCalorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMealSumCalorie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(108, 90);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(184, 80);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(373, 90);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(184, 80);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnMemberComp
            // 
            this.btnMemberComp.Location = new System.Drawing.Point(638, 90);
            this.btnMemberComp.Name = "btnMemberComp";
            this.btnMemberComp.Size = new System.Drawing.Size(184, 80);
            this.btnMemberComp.TabIndex = 0;
            this.btnMemberComp.Text = "Member Comparisons";
            this.btnMemberComp.UseVisualStyleBackColor = true;
            this.btnMemberComp.Click += new System.EventHandler(this.btnMemberComp_Click);
            // 
            // btnFoodSt
            // 
            this.btnFoodSt.Location = new System.Drawing.Point(903, 90);
            this.btnFoodSt.Name = "btnFoodSt";
            this.btnFoodSt.Size = new System.Drawing.Size(184, 80);
            this.btnFoodSt.TabIndex = 0;
            this.btnFoodSt.Text = "Food Statistics";
            this.btnFoodSt.UseVisualStyleBackColor = true;
            this.btnFoodSt.Click += new System.EventHandler(this.btnFoodSt_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(1168, 90);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(184, 80);
            this.btnBMI.TabIndex = 0;
            this.btnBMI.Text = "BMI Calculator";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // dtpHomeDate
            // 
            this.dtpHomeDate.Checked = false;
            this.dtpHomeDate.Location = new System.Drawing.Point(12, 222);
            this.dtpHomeDate.Name = "dtpHomeDate";
            this.dtpHomeDate.Size = new System.Drawing.Size(445, 35);
            this.dtpHomeDate.TabIndex = 1;
            this.dtpHomeDate.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            this.dtpHomeDate.ValueChanged += new System.EventHandler(this.dtpHomeDate_ValueChanged);
            // 
            // lblSumCalorie
            // 
            this.lblSumCalorie.Location = new System.Drawing.Point(63, 432);
            this.lblSumCalorie.Name = "lblSumCalorie";
            this.lblSumCalorie.Size = new System.Drawing.Size(202, 97);
            this.lblSumCalorie.TabIndex = 2;
            this.lblSumCalorie.Text = "1500 Calories \r\nEaten Today ";
            // 
            // lblRemainCalorie
            // 
            this.lblRemainCalorie.Location = new System.Drawing.Point(324, 418);
            this.lblRemainCalorie.Name = "lblRemainCalorie";
            this.lblRemainCalorie.Size = new System.Drawing.Size(188, 111);
            this.lblRemainCalorie.TabIndex = 2;
            this.lblRemainCalorie.Text = "1000 Calories \r\nyou need to take for today";
            // 
            // lblRemainWater
            // 
            this.lblRemainWater.Location = new System.Drawing.Point(576, 418);
            this.lblRemainWater.Name = "lblRemainWater";
            this.lblRemainWater.Size = new System.Drawing.Size(154, 140);
            this.lblRemainWater.TabIndex = 2;
            this.lblRemainWater.Text = "You should drink 4 more glasses of water today.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carbohydrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 724);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Protein";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 724);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fat";
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Location = new System.Drawing.Point(152, 775);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(98, 29);
            this.lblCarbo.TabIndex = 2;
            this.lblCarbo.Text = "245/500";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(368, 766);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(72, 29);
            this.lblPro.TabIndex = 2;
            this.lblPro.Text = "44/85";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(535, 769);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(72, 29);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "55/60";
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(832, 198);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(160, 87);
            this.btnWater.TabIndex = 3;
            this.btnWater.Text = "+1 Glass of Water";
            this.btnWater.UseVisualStyleBackColor = true;
            // 
            // btnAteSomething
            // 
            this.btnAteSomething.Location = new System.Drawing.Point(1022, 198);
            this.btnAteSomething.Name = "btnAteSomething";
            this.btnAteSomething.Size = new System.Drawing.Size(160, 87);
            this.btnAteSomething.TabIndex = 3;
            this.btnAteSomething.Text = "I ate something";
            this.btnAteSomething.UseVisualStyleBackColor = true;
            // 
            // btnProgramChanger
            // 
            this.btnProgramChanger.Location = new System.Drawing.Point(1215, 198);
            this.btnProgramChanger.Name = "btnProgramChanger";
            this.btnProgramChanger.Size = new System.Drawing.Size(160, 87);
            this.btnProgramChanger.TabIndex = 3;
            this.btnProgramChanger.Text = "Change My Program";
            this.btnProgramChanger.UseVisualStyleBackColor = true;
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.Location = new System.Drawing.Point(1409, 198);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(160, 87);
            this.btnProfileUpdate.TabIndex = 3;
            this.btnProfileUpdate.Text = "Profile Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvDailyFoodList
            // 
            this.dgvDailyFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyFoodList.Location = new System.Drawing.Point(829, 374);
            this.dgvDailyFoodList.Name = "dgvDailyFoodList";
            this.dgvDailyFoodList.RowHeadersWidth = 92;
            this.dgvDailyFoodList.RowTemplate.Height = 37;
            this.dgvDailyFoodList.Size = new System.Drawing.Size(740, 817);
            this.dgvDailyFoodList.TabIndex = 4;
            // 
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Location = new System.Drawing.Point(1378, 315);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(191, 37);
            this.cmbMeal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1273, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Filter";
            // 
            // cmbMealSumCalorie
            // 
            this.cmbMealSumCalorie.FormattingEnabled = true;
            this.cmbMealSumCalorie.Location = new System.Drawing.Point(64, 994);
            this.cmbMealSumCalorie.Name = "cmbMealSumCalorie";
            this.cmbMealSumCalorie.Size = new System.Drawing.Size(191, 37);
            this.cmbMealSumCalorie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 949);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Today\'s total calories based on meals";
            // 
            // lblMealSumCalorie
            // 
            this.lblMealSumCalorie.AutoSize = true;
            this.lblMealSumCalorie.Location = new System.Drawing.Point(277, 1002);
            this.lblMealSumCalorie.Name = "lblMealSumCalorie";
            this.lblMealSumCalorie.Size = new System.Drawing.Size(65, 29);
            this.lblMealSumCalorie.TabIndex = 2;
            this.lblMealSumCalorie.Text = "2500";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 1203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMealSumCalorie);
            this.Controls.Add(this.cmbMeal);
            this.Controls.Add(this.dgvDailyFoodList);
            this.Controls.Add(this.btnProfileUpdate);
            this.Controls.Add(this.btnProgramChanger);
            this.Controls.Add(this.btnAteSomething);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMealSumCalorie);
            this.Controls.Add(this.lblCarbo);
            this.Controls.Add(this.lblRemainWater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRemainCalorie);
            this.Controls.Add(this.lblSumCalorie);
            this.Controls.Add(this.dtpHomeDate);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnFoodSt);
            this.Controls.Add(this.btnMemberComp);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnReports);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnMemberComp;
        private System.Windows.Forms.Button btnFoodSt;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.DateTimePicker dtpHomeDate;
        private System.Windows.Forms.Label lblSumCalorie;
        private System.Windows.Forms.Label lblRemainCalorie;
        private System.Windows.Forms.Label lblRemainWater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCarbo;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnAteSomething;
        private System.Windows.Forms.Button btnProgramChanger;
        private System.Windows.Forms.Button btnProfileUpdate;
        private System.Windows.Forms.DataGridView dgvDailyFoodList;
        private System.Windows.Forms.ComboBox cmbMeal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMealSumCalorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealSumCalorie;
    }
}