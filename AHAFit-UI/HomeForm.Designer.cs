
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
            this.lblMotivation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).BeginInit();
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
            // dtpHomeDate
            // 
            this.dtpHomeDate.Checked = false;
            this.dtpHomeDate.Location = new System.Drawing.Point(45, 268);
            this.dtpHomeDate.Name = "dtpHomeDate";
            this.dtpHomeDate.Size = new System.Drawing.Size(382, 31);
            this.dtpHomeDate.TabIndex = 1;
            this.dtpHomeDate.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            this.dtpHomeDate.ValueChanged += new System.EventHandler(this.dtpHomeDate_ValueChanged);
            // 
            // lblSumCalorie
            // 
            this.lblSumCalorie.Location = new System.Drawing.Point(54, 372);
            this.lblSumCalorie.Name = "lblSumCalorie";
            this.lblSumCalorie.Size = new System.Drawing.Size(173, 84);
            this.lblSumCalorie.TabIndex = 2;
            this.lblSumCalorie.Text = "1500 Calories \r\nEaten Today ";
            // 
            // lblRemainCalorie
            // 
            this.lblRemainCalorie.Location = new System.Drawing.Point(278, 360);
            this.lblRemainCalorie.Name = "lblRemainCalorie";
            this.lblRemainCalorie.Size = new System.Drawing.Size(161, 96);
            this.lblRemainCalorie.TabIndex = 2;
            this.lblRemainCalorie.Text = "1000 Calories \r\nyou need to take for today";
            // 
            // lblRemainWater
            // 
            this.lblRemainWater.Location = new System.Drawing.Point(494, 360);
            this.lblRemainWater.Name = "lblRemainWater";
            this.lblRemainWater.Size = new System.Drawing.Size(204, 177);
            this.lblRemainWater.TabIndex = 2;
            this.lblRemainWater.Text = "You should drink 4 more glasses of water today.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carbohydrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Protein";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fat";
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Location = new System.Drawing.Point(130, 668);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(90, 25);
            this.lblCarbo.TabIndex = 2;
            this.lblCarbo.Text = "245/500";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(315, 660);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(66, 25);
            this.lblPro.TabIndex = 2;
            this.lblPro.Text = "44/85";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(459, 663);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(66, 25);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "55/60";
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(713, 171);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(137, 75);
            this.btnWater.TabIndex = 3;
            this.btnWater.Text = "+1 Glass of Water";
            this.btnWater.UseVisualStyleBackColor = true;
            // 
            // btnAteSomething
            // 
            this.btnAteSomething.Location = new System.Drawing.Point(876, 171);
            this.btnAteSomething.Name = "btnAteSomething";
            this.btnAteSomething.Size = new System.Drawing.Size(137, 75);
            this.btnAteSomething.TabIndex = 3;
            this.btnAteSomething.Text = "I ate something";
            this.btnAteSomething.UseVisualStyleBackColor = true;
            // 
            // btnProgramChanger
            // 
            this.btnProgramChanger.Location = new System.Drawing.Point(1041, 171);
            this.btnProgramChanger.Name = "btnProgramChanger";
            this.btnProgramChanger.Size = new System.Drawing.Size(137, 75);
            this.btnProgramChanger.TabIndex = 3;
            this.btnProgramChanger.Text = "Change My Program";
            this.btnProgramChanger.UseVisualStyleBackColor = true;
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.Location = new System.Drawing.Point(1208, 171);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(137, 75);
            this.btnProfileUpdate.TabIndex = 3;
            this.btnProfileUpdate.Text = "Profile Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvDailyFoodList
            // 
            this.dgvDailyFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyFoodList.Location = new System.Drawing.Point(711, 322);
            this.dgvDailyFoodList.Name = "dgvDailyFoodList";
            this.dgvDailyFoodList.RowHeadersWidth = 92;
            this.dgvDailyFoodList.RowTemplate.Height = 37;
            this.dgvDailyFoodList.Size = new System.Drawing.Size(634, 704);
            this.dgvDailyFoodList.TabIndex = 4;
            // 
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Location = new System.Drawing.Point(1181, 272);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(164, 33);
            this.cmbMeal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1091, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Filter";
            // 
            // cmbMealSumCalorie
            // 
            this.cmbMealSumCalorie.FormattingEnabled = true;
            this.cmbMealSumCalorie.Location = new System.Drawing.Point(55, 857);
            this.cmbMealSumCalorie.Name = "cmbMealSumCalorie";
            this.cmbMealSumCalorie.Size = new System.Drawing.Size(164, 33);
            this.cmbMealSumCalorie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 818);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Today\'s total calories based on meals";
            // 
            // lblMealSumCalorie
            // 
            this.lblMealSumCalorie.AutoSize = true;
            this.lblMealSumCalorie.Location = new System.Drawing.Point(237, 864);
            this.lblMealSumCalorie.Name = "lblMealSumCalorie";
            this.lblMealSumCalorie.Size = new System.Drawing.Size(60, 25);
            this.lblMealSumCalorie.TabIndex = 2;
            this.lblMealSumCalorie.Text = "2500";
            // 
            // lblMotivation
            // 
            this.lblMotivation.Location = new System.Drawing.Point(55, 188);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(612, 58);
            this.lblMotivation.TabIndex = 7;
            this.lblMotivation.Text = "Welcome";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 1037);
            this.Controls.Add(this.lblMotivation);
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
            this.Load += new System.EventHandler(this.HomeForm_Load);
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
        private System.Windows.Forms.Label lblMotivation;
    }
}