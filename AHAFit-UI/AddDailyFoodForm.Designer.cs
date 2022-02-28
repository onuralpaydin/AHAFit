
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
            this.dtpEatDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEatMeal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveEat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFoodType = new System.Windows.Forms.ComboBox();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.btnCheckImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohydrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewFoodName
            // 
            this.txtNewFoodName.Location = new System.Drawing.Point(190, 48);
            this.txtNewFoodName.Name = "txtNewFoodName";
            this.txtNewFoodName.Size = new System.Drawing.Size(100, 31);
            this.txtNewFoodName.TabIndex = 0;
            // 
            // txtPhotoUrl
            // 
            this.txtPhotoUrl.Location = new System.Drawing.Point(508, 108);
            this.txtPhotoUrl.Name = "txtPhotoUrl";
            this.txtPhotoUrl.Size = new System.Drawing.Size(148, 31);
            this.txtPhotoUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Carbohydrate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Protein";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Photo URL";
            // 
            // nudCalorie
            // 
            this.nudCalorie.DecimalPlaces = 2;
            this.nudCalorie.Location = new System.Drawing.Point(190, 111);
            this.nudCalorie.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(120, 31);
            this.nudCalorie.TabIndex = 2;
            // 
            // nudCarbohydrate
            // 
            this.nudCarbohydrate.DecimalPlaces = 2;
            this.nudCarbohydrate.Location = new System.Drawing.Point(190, 165);
            this.nudCarbohydrate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCarbohydrate.Name = "nudCarbohydrate";
            this.nudCarbohydrate.Size = new System.Drawing.Size(120, 31);
            this.nudCarbohydrate.TabIndex = 2;
            // 
            // nudProtein
            // 
            this.nudProtein.DecimalPlaces = 2;
            this.nudProtein.Location = new System.Drawing.Point(190, 219);
            this.nudProtein.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(120, 31);
            this.nudProtein.TabIndex = 2;
            // 
            // nudFat
            // 
            this.nudFat.DecimalPlaces = 2;
            this.nudFat.Location = new System.Drawing.Point(508, 54);
            this.nudFat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(148, 31);
            this.nudFat.TabIndex = 2;
            // 
            // btnNewFoodSave
            // 
            this.btnNewFoodSave.Location = new System.Drawing.Point(418, 203);
            this.btnNewFoodSave.Name = "btnNewFoodSave";
            this.btnNewFoodSave.Size = new System.Drawing.Size(180, 61);
            this.btnNewFoodSave.TabIndex = 4;
            this.btnNewFoodSave.Text = "Save New Food";
            this.btnNewFoodSave.UseVisualStyleBackColor = true;
            this.btnNewFoodSave.Click += new System.EventHandler(this.btnNewFoodSave_Click);
            // 
            // txtFoodSearchBox
            // 
            this.txtFoodSearchBox.Location = new System.Drawing.Point(32, 58);
            this.txtFoodSearchBox.Name = "txtFoodSearchBox";
            this.txtFoodSearchBox.Size = new System.Drawing.Size(298, 31);
            this.txtFoodSearchBox.TabIndex = 5;
            this.txtFoodSearchBox.TextChanged += new System.EventHandler(this.txtFoodSearchBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Search Food";
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(32, 116);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowHeadersWidth = 82;
            this.dgvFoods.RowTemplate.Height = 33;
            this.dgvFoods.Size = new System.Drawing.Size(1688, 187);
            this.dgvFoods.TabIndex = 7;
            // 
            // dtpEatDate
            // 
            this.dtpEatDate.Location = new System.Drawing.Point(100, 335);
            this.dtpEatDate.Name = "dtpEatDate";
            this.dtpEatDate.Size = new System.Drawing.Size(397, 31);
            this.dtpEatDate.TabIndex = 8;
            // 
            // cmbEatMeal
            // 
            this.cmbEatMeal.FormattingEnabled = true;
            this.cmbEatMeal.Location = new System.Drawing.Point(615, 337);
            this.cmbEatMeal.Name = "cmbEatMeal";
            this.cmbEatMeal.Size = new System.Drawing.Size(171, 33);
            this.cmbEatMeal.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Meal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Date";
            // 
            // btnSaveEat
            // 
            this.btnSaveEat.Location = new System.Drawing.Point(842, 326);
            this.btnSaveEat.Name = "btnSaveEat";
            this.btnSaveEat.Size = new System.Drawing.Size(154, 53);
            this.btnSaveEat.TabIndex = 11;
            this.btnSaveEat.Text = "Save";
            this.btnSaveEat.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(32, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 269);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Food";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Food Type";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.Location = new System.Drawing.Point(508, 157);
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.Size = new System.Drawing.Size(148, 33);
            this.cmbFoodType.TabIndex = 3;
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(1088, 328);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(632, 394);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFood.TabIndex = 13;
            this.pbFood.TabStop = false;
            // 
            // btnCheckImage
            // 
            this.btnCheckImage.Location = new System.Drawing.Point(662, 101);
            this.btnCheckImage.Name = "btnCheckImage";
            this.btnCheckImage.Size = new System.Drawing.Size(213, 48);
            this.btnCheckImage.TabIndex = 6;
            this.btnCheckImage.Text = "Check The Image";
            this.btnCheckImage.UseVisualStyleBackColor = true;
            this.btnCheckImage.Click += new System.EventHandler(this.btnCheckImage_Click);
            // 
            // AddDailyFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 776);
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
    }
}