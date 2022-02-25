
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
            this.components = new System.ComponentModel.Container();
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
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMealSumCalorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMealSumCalorie = new System.Windows.Forms.Label();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDailyFoodList = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.lblRemainWater.Location = new System.Drawing.Point(463, 360);
            this.lblRemainWater.Name = "lblRemainWater";
            this.lblRemainWater.Size = new System.Drawing.Size(204, 136);
            this.lblRemainWater.TabIndex = 2;
            this.lblRemainWater.Text = "You should drink 4 more glasses of water today.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carbohydrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Protein";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fat";
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Location = new System.Drawing.Point(129, 644);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(48, 25);
            this.lblCarbo.TabIndex = 2;
            this.lblCarbo.Text = "200";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(314, 636);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(48, 25);
            this.lblPro.TabIndex = 2;
            this.lblPro.Text = "200";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(471, 636);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(48, 25);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "200";
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(713, 171);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(137, 75);
            this.btnWater.TabIndex = 3;
            this.btnWater.Text = "+1 Glass of Water";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
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
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Location = new System.Drawing.Point(1536, 272);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(164, 33);
            this.cmbMeal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1446, 274);
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
            this.cmbMealSumCalorie.SelectedIndexChanged += new System.EventHandler(this.cmbMealSumCalorie_SelectedIndexChanged);
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
            this.lblMealSumCalorie.Size = new System.Drawing.Size(141, 25);
            this.lblMealSumCalorie.TabIndex = 2;
            this.lblMealSumCalorie.Text = "2500 calories";
            // 
            // lblMotivation
            // 
            this.lblMotivation.Location = new System.Drawing.Point(55, 188);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(612, 58);
            this.lblMotivation.TabIndex = 7;
            this.lblMotivation.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Received today:";
            // 
            // dgvDailyFoodList
            // 
            this.dgvDailyFoodList.AllowUserToAddRows = false;
            this.dgvDailyFoodList.AllowUserToDeleteRows = false;
            this.dgvDailyFoodList.AllowUserToResizeColumns = false;
            this.dgvDailyFoodList.AllowUserToResizeRows = false;
            this.dgvDailyFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Calorie,
            this.Carbohydrate,
            this.Protein,
            this.Fat});
            this.dgvDailyFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDailyFoodList.Location = new System.Drawing.Point(692, 311);
            this.dgvDailyFoodList.Name = "dgvDailyFoodList";
            this.dgvDailyFoodList.ReadOnly = true;
            this.dgvDailyFoodList.RowHeadersVisible = false;
            this.dgvDailyFoodList.RowHeadersWidth = 82;
            this.dgvDailyFoodList.RowTemplate.Height = 33;
            this.dgvDailyFoodList.Size = new System.Drawing.Size(1008, 714);
            this.dgvDailyFoodList.TabIndex = 9;
            this.dgvDailyFoodList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDailyFoodList_MouseDown);
            // 
            // FoodName
            // 
            this.FoodName.FillWeight = 83.58209F;
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 10;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 168;
            // 
            // Calorie
            // 
            this.Calorie.FillWeight = 79.38345F;
            this.Calorie.HeaderText = "Calorie";
            this.Calorie.MinimumWidth = 10;
            this.Calorie.Name = "Calorie";
            this.Calorie.ReadOnly = true;
            this.Calorie.Width = 160;
            // 
            // Carbohydrate
            // 
            this.Carbohydrate.FillWeight = 145.2617F;
            this.Carbohydrate.HeaderText = "Carbohydrate";
            this.Carbohydrate.MinimumWidth = 10;
            this.Carbohydrate.Name = "Carbohydrate";
            this.Carbohydrate.ReadOnly = true;
            this.Carbohydrate.Width = 292;
            // 
            // Protein
            // 
            this.Protein.FillWeight = 106.6229F;
            this.Protein.HeaderText = "Protein";
            this.Protein.MinimumWidth = 10;
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            this.Protein.Width = 214;
            // 
            // Fat
            // 
            this.Fat.FillWeight = 85.14986F;
            this.Fat.HeaderText = "Fat";
            this.Fat.MinimumWidth = 10;
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            this.Fat.Width = 171;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 80);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 1037);
            this.Controls.Add(this.dgvDailyFoodList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMotivation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMealSumCalorie);
            this.Controls.Add(this.cmbMeal);
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
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbMeal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMealSumCalorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealSumCalorie;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDailyFoodList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
    }
}