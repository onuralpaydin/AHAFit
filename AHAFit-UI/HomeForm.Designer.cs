
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
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateText = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loseWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gainWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainYourWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flwPnlLeftSide = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnFoodSt = new System.Windows.Forms.Button();
            this.btnMemberComp = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlResizeBottom = new System.Windows.Forms.Panel();
            this.pnlResizeRight = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlBasedOnMeals = new System.Windows.Forms.Panel();
            this.pnlEatenToday = new System.Windows.Forms.Panel();
            this.pnlDailyCalorie = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.flwPnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlBasedOnMeals.SuspendLayout();
            this.pnlEatenToday.SuspendLayout();
            this.pnlDailyCalorie.SuspendLayout();
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
            // dtpHomeDate
            // 
            this.dtpHomeDate.Checked = false;
            this.dtpHomeDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHomeDate.Location = new System.Drawing.Point(41, 214);
            this.dtpHomeDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHomeDate.Name = "dtpHomeDate";
            this.dtpHomeDate.Size = new System.Drawing.Size(634, 46);
            this.dtpHomeDate.TabIndex = 1;
            this.dtpHomeDate.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            this.dtpHomeDate.ValueChanged += new System.EventHandler(this.dtpHomeDate_ValueChanged);
            // 
            // lblSumCalorie
            // 
            this.lblSumCalorie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCalorie.ForeColor = System.Drawing.Color.White;
            this.lblSumCalorie.Location = new System.Drawing.Point(5, 29);
            this.lblSumCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumCalorie.Name = "lblSumCalorie";
            this.lblSumCalorie.Size = new System.Drawing.Size(290, 70);
            this.lblSumCalorie.TabIndex = 2;
            this.lblSumCalorie.Text = "1500";
            this.lblSumCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainCalorie
            // 
            this.lblRemainCalorie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainCalorie.ForeColor = System.Drawing.Color.White;
            this.lblRemainCalorie.Location = new System.Drawing.Point(373, 29);
            this.lblRemainCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemainCalorie.Name = "lblRemainCalorie";
            this.lblRemainCalorie.Size = new System.Drawing.Size(290, 70);
            this.lblRemainCalorie.TabIndex = 2;
            this.lblRemainCalorie.Text = "1500";
            this.lblRemainCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainWater
            // 
            this.lblRemainWater.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainWater.ForeColor = System.Drawing.Color.White;
            this.lblRemainWater.Location = new System.Drawing.Point(741, 29);
            this.lblRemainWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemainWater.Name = "lblRemainWater";
            this.lblRemainWater.Size = new System.Drawing.Size(290, 157);
            this.lblRemainWater.TabIndex = 2;
            this.lblRemainWater.Text = "You should drink 4 more glasses of water today.";
            this.lblRemainWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(371, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carbohydrate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 41);
            this.label5.TabIndex = 2;
            this.label5.Text = "Protein";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(740, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarbo
            // 
            this.lblCarbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbo.ForeColor = System.Drawing.Color.White;
            this.lblCarbo.Location = new System.Drawing.Point(370, 154);
            this.lblCarbo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(290, 45);
            this.lblCarbo.TabIndex = 2;
            this.lblCarbo.Text = "200";
            this.lblCarbo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPro
            // 
            this.lblPro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.ForeColor = System.Drawing.Color.White;
            this.lblPro.Location = new System.Drawing.Point(0, 154);
            this.lblPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(290, 45);
            this.lblPro.TabIndex = 2;
            this.lblPro.Text = "200";
            this.lblPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFat
            // 
            this.lblFat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.ForeColor = System.Drawing.Color.White;
            this.lblFat.Location = new System.Drawing.Point(740, 154);
            this.lblFat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(290, 45);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "200";
            this.lblFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWater
            // 
            this.btnWater.FlatAppearance.BorderSize = 0;
            this.btnWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWater.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWater.ForeColor = System.Drawing.Color.White;
            this.btnWater.Location = new System.Drawing.Point(1104, 42);
            this.btnWater.Margin = new System.Windows.Forms.Padding(2);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(190, 100);
            this.btnWater.TabIndex = 3;
            this.btnWater.Text = "+1 Glass of Water";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnAteSomething
            // 
            this.btnAteSomething.FlatAppearance.BorderSize = 0;
            this.btnAteSomething.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAteSomething.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAteSomething.ForeColor = System.Drawing.Color.White;
            this.btnAteSomething.Location = new System.Drawing.Point(1380, 42);
            this.btnAteSomething.Margin = new System.Windows.Forms.Padding(2);
            this.btnAteSomething.Name = "btnAteSomething";
            this.btnAteSomething.Size = new System.Drawing.Size(190, 100);
            this.btnAteSomething.TabIndex = 3;
            this.btnAteSomething.Text = "I ate something";
            this.btnAteSomething.UseVisualStyleBackColor = true;
            this.btnAteSomething.Click += new System.EventHandler(this.btnAteSomething_Click);
            // 
            // btnProgramChanger
            // 
            this.btnProgramChanger.FlatAppearance.BorderSize = 0;
            this.btnProgramChanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramChanger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramChanger.ForeColor = System.Drawing.Color.White;
            this.btnProgramChanger.Location = new System.Drawing.Point(1656, 42);
            this.btnProgramChanger.Margin = new System.Windows.Forms.Padding(2);
            this.btnProgramChanger.Name = "btnProgramChanger";
            this.btnProgramChanger.Size = new System.Drawing.Size(190, 100);
            this.btnProgramChanger.TabIndex = 3;
            this.btnProgramChanger.Text = "Change My Program";
            this.btnProgramChanger.UseVisualStyleBackColor = true;
            this.btnProgramChanger.Click += new System.EventHandler(this.btnProgramChanger_Click);
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.FlatAppearance.BorderSize = 0;
            this.btnProfileUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProfileUpdate.Location = new System.Drawing.Point(1932, 42);
            this.btnProfileUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(190, 100);
            this.btnProfileUpdate.TabIndex = 3;
            this.btnProfileUpdate.Text = "Profile Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = true;
            this.btnProfileUpdate.Click += new System.EventHandler(this.btnProfileUpdate_Click);
            // 
            // cmbMealSumCalorie
            // 
            this.cmbMealSumCalorie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealSumCalorie.FormattingEnabled = true;
            this.cmbMealSumCalorie.Location = new System.Drawing.Point(47, 120);
            this.cmbMealSumCalorie.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMealSumCalorie.Name = "cmbMealSumCalorie";
            this.cmbMealSumCalorie.Size = new System.Drawing.Size(322, 53);
            this.cmbMealSumCalorie.TabIndex = 5;
            this.cmbMealSumCalorie.SelectedIndexChanged += new System.EventHandler(this.cmbMealSumCalorie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Today\'s total calories based on meals";
            // 
            // lblMealSumCalorie
            // 
            this.lblMealSumCalorie.AutoSize = true;
            this.lblMealSumCalorie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealSumCalorie.ForeColor = System.Drawing.Color.White;
            this.lblMealSumCalorie.Location = new System.Drawing.Point(397, 123);
            this.lblMealSumCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealSumCalorie.Name = "lblMealSumCalorie";
            this.lblMealSumCalorie.Size = new System.Drawing.Size(223, 45);
            this.lblMealSumCalorie.TabIndex = 2;
            this.lblMealSumCalorie.Text = "2500 calories";
            // 
            // lblMotivation
            // 
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivation.ForeColor = System.Drawing.Color.White;
            this.lblMotivation.Location = new System.Drawing.Point(31, 42);
            this.lblMotivation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(172, 48);
            this.lblMotivation.TabIndex = 7;
            this.lblMotivation.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(421, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Eaten Today";
            // 
            // dgvDailyFoodList
            // 
            this.dgvDailyFoodList.AllowUserToAddRows = false;
            this.dgvDailyFoodList.AllowUserToDeleteRows = false;
            this.dgvDailyFoodList.AllowUserToResizeColumns = false;
            this.dgvDailyFoodList.AllowUserToResizeRows = false;
            this.dgvDailyFoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Calorie,
            this.Carbohydrate,
            this.Protein,
            this.Fat,
            this.FoodId,
            this.FoodType});
            this.dgvDailyFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDailyFoodList.Location = new System.Drawing.Point(1103, 163);
            this.dgvDailyFoodList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDailyFoodList.Name = "dgvDailyFoodList";
            this.dgvDailyFoodList.ReadOnly = true;
            this.dgvDailyFoodList.RowHeadersVisible = false;
            this.dgvDailyFoodList.RowHeadersWidth = 82;
            this.dgvDailyFoodList.RowTemplate.Height = 33;
            this.dgvDailyFoodList.Size = new System.Drawing.Size(1019, 929);
            this.dgvDailyFoodList.TabIndex = 9;
            this.dgvDailyFoodList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDailyFoodList_MouseDown);
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.FillWeight = 130F;
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 10;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Calorie
            // 
            this.Calorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Calorie.FillWeight = 80F;
            this.Calorie.HeaderText = "Calorie";
            this.Calorie.MinimumWidth = 10;
            this.Calorie.Name = "Calorie";
            this.Calorie.ReadOnly = true;
            // 
            // Carbohydrate
            // 
            this.Carbohydrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Carbohydrate.FillWeight = 144F;
            this.Carbohydrate.HeaderText = "Carbohydrate";
            this.Carbohydrate.MinimumWidth = 10;
            this.Carbohydrate.Name = "Carbohydrate";
            this.Carbohydrate.ReadOnly = true;
            // 
            // Protein
            // 
            this.Protein.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Protein.HeaderText = "Protein";
            this.Protein.MinimumWidth = 10;
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            // 
            // Fat
            // 
            this.Fat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fat.FillWeight = 80F;
            this.Fat.HeaderText = "Fat";
            this.Fat.MinimumWidth = 10;
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "FoodId";
            this.FoodId.MinimumWidth = 10;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Visible = false;
            // 
            // FoodType
            // 
            this.FoodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodType.HeaderText = "FoodType";
            this.FoodType.MinimumWidth = 10;
            this.FoodType.Name = "FoodType";
            this.FoodType.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblDateText
            // 
            this.lblDateText.AutoSize = true;
            this.lblDateText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateText.ForeColor = System.Drawing.Color.White;
            this.lblDateText.Location = new System.Drawing.Point(31, 127);
            this.lblDateText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(97, 48);
            this.lblDateText.TabIndex = 10;
            this.lblDateText.Text = "Date";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loseWeightToolStripMenuItem,
            this.gainWeightToolStripMenuItem,
            this.maintainYourWeightToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(352, 136);
            // 
            // loseWeightToolStripMenuItem
            // 
            this.loseWeightToolStripMenuItem.Name = "loseWeightToolStripMenuItem";
            this.loseWeightToolStripMenuItem.Size = new System.Drawing.Size(351, 44);
            this.loseWeightToolStripMenuItem.Text = "Lose Weight";
            this.loseWeightToolStripMenuItem.Click += new System.EventHandler(this.loseWeightToolStripMenuItem_Click);
            // 
            // gainWeightToolStripMenuItem
            // 
            this.gainWeightToolStripMenuItem.Name = "gainWeightToolStripMenuItem";
            this.gainWeightToolStripMenuItem.Size = new System.Drawing.Size(351, 44);
            this.gainWeightToolStripMenuItem.Text = "Gain Weight";
            this.gainWeightToolStripMenuItem.Click += new System.EventHandler(this.loseWeightToolStripMenuItem_Click);
            // 
            // maintainYourWeightToolStripMenuItem
            // 
            this.maintainYourWeightToolStripMenuItem.Name = "maintainYourWeightToolStripMenuItem";
            this.maintainYourWeightToolStripMenuItem.Size = new System.Drawing.Size(351, 44);
            this.maintainYourWeightToolStripMenuItem.Text = "Maintain Your Weight";
            this.maintainYourWeightToolStripMenuItem.Click += new System.EventHandler(this.loseWeightToolStripMenuItem_Click);
            // 
            // flwPnlLeftSide
            // 
            this.flwPnlLeftSide.Controls.Add(this.pictureBox1);
            this.flwPnlLeftSide.Controls.Add(this.btnHome);
            this.flwPnlLeftSide.Controls.Add(this.btnHistory);
            this.flwPnlLeftSide.Controls.Add(this.btnBMI);
            this.flwPnlLeftSide.Controls.Add(this.btnFoodSt);
            this.flwPnlLeftSide.Controls.Add(this.btnMemberComp);
            this.flwPnlLeftSide.Controls.Add(this.label9);
            this.flwPnlLeftSide.Controls.Add(this.label11);
            this.flwPnlLeftSide.Controls.Add(this.label10);
            this.flwPnlLeftSide.Controls.Add(this.label12);
            this.flwPnlLeftSide.Controls.Add(this.label13);
            this.flwPnlLeftSide.Controls.Add(this.label14);
            this.flwPnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwPnlLeftSide.Location = new System.Drawing.Point(0, 56);
            this.flwPnlLeftSide.Margin = new System.Windows.Forms.Padding(7);
            this.flwPnlLeftSide.Name = "flwPnlLeftSide";
            this.flwPnlLeftSide.Size = new System.Drawing.Size(467, 1144);
            this.flwPnlLeftSide.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 241);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::AHAFit_UI.Properties.Resources.history;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 257);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(467, 112);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = global::AHAFit_UI.Properties.Resources.history;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(2, 373);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(467, 112);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.FlatAppearance.BorderSize = 0;
            this.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.ForeColor = System.Drawing.Color.White;
            this.btnBMI.Image = global::AHAFit_UI.Properties.Resources.history;
            this.btnBMI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBMI.Location = new System.Drawing.Point(2, 489);
            this.btnBMI.Margin = new System.Windows.Forms.Padding(2);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(467, 112);
            this.btnBMI.TabIndex = 0;
            this.btnBMI.Text = "BMI Calculator";
            this.btnBMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnFoodSt
            // 
            this.btnFoodSt.FlatAppearance.BorderSize = 0;
            this.btnFoodSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodSt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodSt.ForeColor = System.Drawing.Color.White;
            this.btnFoodSt.Image = global::AHAFit_UI.Properties.Resources.history;
            this.btnFoodSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodSt.Location = new System.Drawing.Point(2, 605);
            this.btnFoodSt.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoodSt.Name = "btnFoodSt";
            this.btnFoodSt.Size = new System.Drawing.Size(467, 112);
            this.btnFoodSt.TabIndex = 0;
            this.btnFoodSt.Text = "Food Statistics";
            this.btnFoodSt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodSt.UseVisualStyleBackColor = true;
            this.btnFoodSt.Click += new System.EventHandler(this.btnFoodSt_Click);
            // 
            // btnMemberComp
            // 
            this.btnMemberComp.FlatAppearance.BorderSize = 0;
            this.btnMemberComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberComp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberComp.ForeColor = System.Drawing.Color.White;
            this.btnMemberComp.Image = global::AHAFit_UI.Properties.Resources.history;
            this.btnMemberComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberComp.Location = new System.Drawing.Point(2, 721);
            this.btnMemberComp.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberComp.Name = "btnMemberComp";
            this.btnMemberComp.Size = new System.Drawing.Size(467, 112);
            this.btnMemberComp.TabIndex = 0;
            this.btnMemberComp.Text = "Member Comparisons";
            this.btnMemberComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberComp.UseVisualStyleBackColor = true;
            this.btnMemberComp.Click += new System.EventHandler(this.btnMemberComp_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(7);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(2621, 56);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(2563, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMain.Controls.Add(this.pnlResizeBottom);
            this.pnlMain.Controls.Add(this.pnlResizeRight);
            this.pnlMain.Controls.Add(this.pnlHome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(467, 56);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(7);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2154, 1144);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlResizeBottom
            // 
            this.pnlResizeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlResizeBottom.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlResizeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResizeBottom.Location = new System.Drawing.Point(0, 1122);
            this.pnlResizeBottom.Margin = new System.Windows.Forms.Padding(7);
            this.pnlResizeBottom.Name = "pnlResizeBottom";
            this.pnlResizeBottom.Size = new System.Drawing.Size(2131, 22);
            this.pnlResizeBottom.TabIndex = 13;
            this.pnlResizeBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseDown);
            this.pnlResizeBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseMove);
            this.pnlResizeBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseUp);
            // 
            // pnlResizeRight
            // 
            this.pnlResizeRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlResizeRight.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlResizeRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResizeRight.Location = new System.Drawing.Point(2131, 0);
            this.pnlResizeRight.Margin = new System.Windows.Forms.Padding(7);
            this.pnlResizeRight.Name = "pnlResizeRight";
            this.pnlResizeRight.Size = new System.Drawing.Size(23, 1144);
            this.pnlResizeRight.TabIndex = 12;
            this.pnlResizeRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseDown);
            this.pnlResizeRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseMove);
            this.pnlResizeRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlResizeRight_MouseUp);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlHome.Controls.Add(this.pnlBasedOnMeals);
            this.pnlHome.Controls.Add(this.pnlEatenToday);
            this.pnlHome.Controls.Add(this.pnlDailyCalorie);
            this.pnlHome.Controls.Add(this.btnAteSomething);
            this.pnlHome.Controls.Add(this.btnWater);
            this.pnlHome.Controls.Add(this.btnProgramChanger);
            this.pnlHome.Controls.Add(this.btnProfileUpdate);
            this.pnlHome.Controls.Add(this.dgvDailyFoodList);
            this.pnlHome.Controls.Add(this.lblDateText);
            this.pnlHome.Controls.Add(this.lblMotivation);
            this.pnlHome.Controls.Add(this.dtpHomeDate);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(7);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(2154, 1144);
            this.pnlHome.TabIndex = 11;
            // 
            // pnlBasedOnMeals
            // 
            this.pnlBasedOnMeals.Controls.Add(this.label1);
            this.pnlBasedOnMeals.Controls.Add(this.lblMealSumCalorie);
            this.pnlBasedOnMeals.Controls.Add(this.cmbMealSumCalorie);
            this.pnlBasedOnMeals.Location = new System.Drawing.Point(41, 871);
            this.pnlBasedOnMeals.Name = "pnlBasedOnMeals";
            this.pnlBasedOnMeals.Size = new System.Drawing.Size(1044, 221);
            this.pnlBasedOnMeals.TabIndex = 14;
            // 
            // pnlEatenToday
            // 
            this.pnlEatenToday.Controls.Add(this.label2);
            this.pnlEatenToday.Controls.Add(this.label5);
            this.pnlEatenToday.Controls.Add(this.lblPro);
            this.pnlEatenToday.Controls.Add(this.label4);
            this.pnlEatenToday.Controls.Add(this.lblCarbo);
            this.pnlEatenToday.Controls.Add(this.label6);
            this.pnlEatenToday.Controls.Add(this.lblFat);
            this.pnlEatenToday.Location = new System.Drawing.Point(41, 585);
            this.pnlEatenToday.Name = "pnlEatenToday";
            this.pnlEatenToday.Size = new System.Drawing.Size(1044, 221);
            this.pnlEatenToday.TabIndex = 13;
            // 
            // pnlDailyCalorie
            // 
            this.pnlDailyCalorie.Controls.Add(this.label7);
            this.pnlDailyCalorie.Controls.Add(this.label3);
            this.pnlDailyCalorie.Controls.Add(this.lblRemainCalorie);
            this.pnlDailyCalorie.Controls.Add(this.lblSumCalorie);
            this.pnlDailyCalorie.Controls.Add(this.lblRemainWater);
            this.pnlDailyCalorie.Location = new System.Drawing.Point(39, 299);
            this.pnlDailyCalorie.Name = "pnlDailyCalorie";
            this.pnlDailyCalorie.Size = new System.Drawing.Size(1044, 221);
            this.pnlDailyCalorie.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(374, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "Left";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eaten";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 41);
            this.label8.TabIndex = 3;
            this.label8.Text = "AHAFit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(2, 835);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(465, 45);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 880);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(465, 45);
            this.label11.TabIndex = 11;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(2, 925);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(465, 45);
            this.label10.TabIndex = 12;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(2, 970);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(465, 45);
            this.label12.TabIndex = 13;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 1015);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(465, 45);
            this.label13.TabIndex = 14;
            this.label13.Text = "AHAFit V1.0";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(2, 1060);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(465, 45);
            this.label14.TabIndex = 15;
            this.label14.Text = "@alperakdemir  @yilmazhuseyin  @onuralpaydin";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2621, 1200);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flwPnlLeftSide);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.flwPnlLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlBasedOnMeals.ResumeLayout(false);
            this.pnlBasedOnMeals.PerformLayout();
            this.pnlEatenToday.ResumeLayout(false);
            this.pnlEatenToday.PerformLayout();
            this.pnlDailyCalorie.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbMealSumCalorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealSumCalorie;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDailyFoodList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loseWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gainWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainYourWeightToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flwPnlLeftSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlResizeRight;
        private System.Windows.Forms.Panel pnlResizeBottom;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDailyCalorie;
        private System.Windows.Forms.Panel pnlEatenToday;
        private System.Windows.Forms.Panel pnlBasedOnMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}