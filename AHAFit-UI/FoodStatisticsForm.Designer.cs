
namespace AHAFit_UI
{
    partial class FoodStatisticsForm
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
            this.lblFoodStatisticsMealMostEaten = new System.Windows.Forms.Label();
            this.btnFoodStatisticsUpdate = new System.Windows.Forms.Button();
            this.lblMostEatenFood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMostEaten = new System.Windows.Forms.Label();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodStatisticsMealMostEaten
            // 
            this.lblFoodStatisticsMealMostEaten.AutoSize = true;
            this.lblFoodStatisticsMealMostEaten.Location = new System.Drawing.Point(1162, 235);
            this.lblFoodStatisticsMealMostEaten.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFoodStatisticsMealMostEaten.Name = "lblFoodStatisticsMealMostEaten";
            this.lblFoodStatisticsMealMostEaten.Size = new System.Drawing.Size(0, 29);
            this.lblFoodStatisticsMealMostEaten.TabIndex = 3;
            // 
            // btnFoodStatisticsUpdate
            // 
            this.btnFoodStatisticsUpdate.FlatAppearance.BorderSize = 0;
            this.btnFoodStatisticsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodStatisticsUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodStatisticsUpdate.ForeColor = System.Drawing.Color.White;
            this.btnFoodStatisticsUpdate.Location = new System.Drawing.Point(351, 688);
            this.btnFoodStatisticsUpdate.Margin = new System.Windows.Forms.Padding(7);
            this.btnFoodStatisticsUpdate.Name = "btnFoodStatisticsUpdate";
            this.btnFoodStatisticsUpdate.Size = new System.Drawing.Size(293, 77);
            this.btnFoodStatisticsUpdate.TabIndex = 10;
            this.btnFoodStatisticsUpdate.Text = "Access Stats";
            this.btnFoodStatisticsUpdate.UseVisualStyleBackColor = true;
            this.btnFoodStatisticsUpdate.Click += new System.EventHandler(this.btnFoodStatisticsUpdate_Click);
            // 
            // lblMostEatenFood
            // 
            this.lblMostEatenFood.AutoSize = true;
            this.lblMostEatenFood.Location = new System.Drawing.Point(317, 180);
            this.lblMostEatenFood.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMostEatenFood.Name = "lblMostEatenFood";
            this.lblMostEatenFood.Size = new System.Drawing.Size(0, 29);
            this.lblMostEatenFood.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(743, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 41);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Calories You Eat:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(283, 608);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(7);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(361, 49);
            this.cmbCategories.TabIndex = 5;
            // 
            // cmbMeals
            // 
            this.cmbMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(283, 512);
            this.cmbMeals.Margin = new System.Windows.Forms.Padding(7);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(361, 49);
            this.cmbMeals.TabIndex = 4;
            this.cmbMeals.SelectedIndexChanged += new System.EventHandler(this.cmbMeals_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 608);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categories :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 512);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meals : ";
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeekly.ForeColor = System.Drawing.Color.White;
            this.rdoWeekly.Location = new System.Drawing.Point(78, 212);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(267, 45);
            this.rdoWeekly.TabIndex = 20;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Weekly Statistics";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.ForeColor = System.Drawing.Color.White;
            this.rdoMonthly.Location = new System.Drawing.Point(78, 312);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(282, 45);
            this.rdoMonthly.TabIndex = 20;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly Statistics";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.ForeColor = System.Drawing.Color.White;
            this.rdoAll.Location = new System.Drawing.Point(78, 412);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(277, 45);
            this.rdoAll.TabIndex = 20;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All Time Statistics";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(743, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "Most Eaten Food :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(750, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblMostEaten
            // 
            this.lblMostEaten.AutoSize = true;
            this.lblMostEaten.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostEaten.ForeColor = System.Drawing.Color.White;
            this.lblMostEaten.Location = new System.Drawing.Point(1024, 216);
            this.lblMostEaten.Name = "lblMostEaten";
            this.lblMostEaten.Size = new System.Drawing.Size(0, 41);
            this.lblMostEaten.TabIndex = 22;
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCal.ForeColor = System.Drawing.Color.White;
            this.lblTotalCal.Location = new System.Drawing.Point(743, 371);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(132, 41);
            this.lblTotalCal.TabIndex = 23;
            this.lblTotalCal.Text = "TotalCal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Statistics";
            // 
            // FoodStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1031);
            this.Controls.Add(this.lblTotalCal);
            this.Controls.Add(this.lblMostEaten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.rdoMonthly);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoWeekly);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMostEatenFood);
            this.Controls.Add(this.btnFoodStatisticsUpdate);
            this.Controls.Add(this.lblFoodStatisticsMealMostEaten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FoodStatisticsForm";
            this.Text = "FoodStatisticsForm";
            this.Load += new System.EventHandler(this.FoodStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFoodStatisticsMealMostEaten;
        private System.Windows.Forms.Button btnFoodStatisticsUpdate;
        private System.Windows.Forms.Label lblMostEatenFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMostEaten;
        private System.Windows.Forms.Label lblTotalCal;
        private System.Windows.Forms.Label label1;
    }
}