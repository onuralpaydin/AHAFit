
namespace AHAFit_UI
{
    partial class AddDailyFoodForm
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
            this.txtNewFoodName = new System.Windows.Forms.TextBox();
            this.txtPhotoUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.nudCarbohydrate = new System.Windows.Forms.NumericUpDown();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.btnNewFoodSave = new System.Windows.Forms.Button();
            this.txtFoodSearchBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEatDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEatMeal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveEat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckImage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFoodType = new System.Windows.Forms.ComboBox();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohydrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewFoodName
            // 
            this.txtNewFoodName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFoodName.Location = new System.Drawing.Point(287, 63);
            this.txtNewFoodName.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewFoodName.Name = "txtNewFoodName";
            this.txtNewFoodName.Size = new System.Drawing.Size(273, 47);
            this.txtNewFoodName.TabIndex = 0;
            // 
            // txtPhotoUrl
            // 
            this.txtPhotoUrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotoUrl.Location = new System.Drawing.Point(837, 256);
            this.txtPhotoUrl.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhotoUrl.Name = "txtPhotoUrl";
            this.txtPhotoUrl.Size = new System.Drawing.Size(250, 47);
            this.txtPhotoUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Carbohydrate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Protein";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(646, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(646, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Photo URL";
            // 
            // nudCalorie
            // 
            this.nudCalorie.DecimalPlaces = 2;
            this.nudCalorie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalorie.Location = new System.Drawing.Point(287, 146);
            this.nudCalorie.Margin = new System.Windows.Forms.Padding(5);
            this.nudCalorie.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(273, 47);
            this.nudCalorie.TabIndex = 2;
            // 
            // nudCarbohydrate
            // 
            this.nudCarbohydrate.DecimalPlaces = 2;
            this.nudCarbohydrate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCarbohydrate.Location = new System.Drawing.Point(287, 229);
            this.nudCarbohydrate.Margin = new System.Windows.Forms.Padding(5);
            this.nudCarbohydrate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCarbohydrate.Name = "nudCarbohydrate";
            this.nudCarbohydrate.Size = new System.Drawing.Size(273, 47);
            this.nudCarbohydrate.TabIndex = 2;
            // 
            // nudProtein
            // 
            this.nudProtein.DecimalPlaces = 2;
            this.nudProtein.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProtein.Location = new System.Drawing.Point(287, 312);
            this.nudProtein.Margin = new System.Windows.Forms.Padding(5);
            this.nudProtein.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(273, 47);
            this.nudProtein.TabIndex = 2;
            // 
            // nudFat
            // 
            this.nudFat.DecimalPlaces = 2;
            this.nudFat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFat.Location = new System.Drawing.Point(837, 50);
            this.nudFat.Margin = new System.Windows.Forms.Padding(5);
            this.nudFat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(250, 47);
            this.nudFat.TabIndex = 2;
            // 
            // btnNewFoodSave
            // 
            this.btnNewFoodSave.FlatAppearance.BorderSize = 0;
            this.btnNewFoodSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFoodSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFoodSave.Location = new System.Drawing.Point(1107, 50);
            this.btnNewFoodSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewFoodSave.Name = "btnNewFoodSave";
            this.btnNewFoodSave.Size = new System.Drawing.Size(179, 253);
            this.btnNewFoodSave.TabIndex = 4;
            this.btnNewFoodSave.Text = "Save New Food";
            this.btnNewFoodSave.UseVisualStyleBackColor = true;
            this.btnNewFoodSave.Click += new System.EventHandler(this.btnNewFoodSave_Click);
            // 
            // txtFoodSearchBox
            // 
            this.txtFoodSearchBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodSearchBox.Location = new System.Drawing.Point(49, 109);
            this.txtFoodSearchBox.Margin = new System.Windows.Forms.Padding(5);
            this.txtFoodSearchBox.Name = "txtFoodSearchBox";
            this.txtFoodSearchBox.Size = new System.Drawing.Size(347, 47);
            this.txtFoodSearchBox.TabIndex = 5;
            this.txtFoodSearchBox.TextChanged += new System.EventHandler(this.txtFoodSearchBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 41);
            this.label8.TabIndex = 6;
            this.label8.Text = "Search Food";
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToResizeRows = false;
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.Calorie,
            this.Carbohydrate,
            this.Protein,
            this.Fat,
            this.FoodType});
            this.dgvFoods.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoods.Location = new System.Drawing.Point(49, 189);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(5);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            this.dgvFoods.RowHeadersWidth = 82;
            this.dgvFoods.RowTemplate.Height = 33;
            this.dgvFoods.Size = new System.Drawing.Size(1926, 217);
            this.dgvFoods.TabIndex = 7;
            this.dgvFoods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFoods_MouseDown);
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "FoodId";
            this.FoodId.MinimumWidth = 10;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Visible = false;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 10;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Calorie
            // 
            this.Calorie.HeaderText = "Calorie";
            this.Calorie.MinimumWidth = 10;
            this.Calorie.Name = "Calorie";
            this.Calorie.ReadOnly = true;
            // 
            // Carbohydrate
            // 
            this.Carbohydrate.HeaderText = "Carbohydrate";
            this.Carbohydrate.MinimumWidth = 10;
            this.Carbohydrate.Name = "Carbohydrate";
            this.Carbohydrate.ReadOnly = true;
            // 
            // Protein
            // 
            this.Protein.HeaderText = "Protein";
            this.Protein.MinimumWidth = 10;
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            // 
            // Fat
            // 
            this.Fat.HeaderText = "Fat";
            this.Fat.MinimumWidth = 10;
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            // 
            // FoodType
            // 
            this.FoodType.HeaderText = "Food Type";
            this.FoodType.MinimumWidth = 10;
            this.FoodType.Name = "FoodType";
            this.FoodType.ReadOnly = true;
            // 
            // dtpEatDate
            // 
            this.dtpEatDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEatDate.Location = new System.Drawing.Point(201, 448);
            this.dtpEatDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEatDate.Name = "dtpEatDate";
            this.dtpEatDate.Size = new System.Drawing.Size(501, 47);
            this.dtpEatDate.TabIndex = 8;
            // 
            // cmbEatMeal
            // 
            this.cmbEatMeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEatMeal.FormattingEnabled = true;
            this.cmbEatMeal.Location = new System.Drawing.Point(848, 448);
            this.cmbEatMeal.Margin = new System.Windows.Forms.Padding(5);
            this.cmbEatMeal.Name = "cmbEatMeal";
            this.cmbEatMeal.Size = new System.Drawing.Size(234, 49);
            this.cmbEatMeal.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(745, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 41);
            this.label9.TabIndex = 10;
            this.label9.Text = "Meal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 448);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 41);
            this.label10.TabIndex = 10;
            this.label10.Text = "Eat Date";
            // 
            // btnSaveEat
            // 
            this.btnSaveEat.FlatAppearance.BorderSize = 0;
            this.btnSaveEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEat.ForeColor = System.Drawing.Color.White;
            this.btnSaveEat.Location = new System.Drawing.Point(1115, 442);
            this.btnSaveEat.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveEat.Name = "btnSaveEat";
            this.btnSaveEat.Size = new System.Drawing.Size(230, 63);
            this.btnSaveEat.TabIndex = 11;
            this.btnSaveEat.Text = "Save";
            this.btnSaveEat.UseVisualStyleBackColor = true;
            this.btnSaveEat.Click += new System.EventHandler(this.btnSaveEat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckImage);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNewFoodName);
            this.groupBox1.Controls.Add(this.txtPhotoUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnNewFoodSave);
            this.groupBox1.Controls.Add(this.nudCalorie);
            this.groupBox1.Controls.Add(this.cmbFoodType);
            this.groupBox1.Controls.Add(this.nudCarbohydrate);
            this.groupBox1.Controls.Add(this.nudFat);
            this.groupBox1.Controls.Add(this.nudProtein);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(49, 569);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1296, 445);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Food";
            // 
            // btnCheckImage
            // 
            this.btnCheckImage.FlatAppearance.BorderSize = 0;
            this.btnCheckImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckImage.Location = new System.Drawing.Point(653, 332);
            this.btnCheckImage.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckImage.Name = "btnCheckImage";
            this.btnCheckImage.Size = new System.Drawing.Size(434, 71);
            this.btnCheckImage.TabIndex = 6;
            this.btnCheckImage.Text = "Check The Image";
            this.btnCheckImage.UseVisualStyleBackColor = true;
            this.btnCheckImage.Click += new System.EventHandler(this.btnCheckImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(646, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 41);
            this.label11.TabIndex = 5;
            this.label11.Text = "Food Type";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.Location = new System.Drawing.Point(837, 152);
            this.cmbFoodType.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.Size = new System.Drawing.Size(250, 49);
            this.cmbFoodType.TabIndex = 3;
            // 
            // pbFood
            // 
            this.pbFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFood.Location = new System.Drawing.Point(1355, 545);
            this.pbFood.Margin = new System.Windows.Forms.Padding(5);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(610, 456);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFood.TabIndex = 13;
            this.pbFood.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1568, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 41);
            this.label7.TabIndex = 14;
            this.label7.Text = "Food Image";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(330, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AddDailyFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1989, 1028);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveEat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEatMeal);
            this.Controls.Add(this.dtpEatDate);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFoodSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddDailyFoodForm";
            this.Text = "AddDailyFoodForm";
            this.Load += new System.EventHandler(this.AddDailyFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohydrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewFoodName;
        private System.Windows.Forms.TextBox txtPhotoUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private System.Windows.Forms.NumericUpDown nudCarbohydrate;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.Button btnNewFoodSave;
        private System.Windows.Forms.TextBox txtFoodSearchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.DateTimePicker dtpEatDate;
        private System.Windows.Forms.ComboBox cmbEatMeal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveEat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFoodType;
        private System.Windows.Forms.Button btnCheckImage;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}