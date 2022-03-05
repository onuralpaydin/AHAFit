
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
            this.lblFood1 = new System.Windows.Forms.Label();
            this.lblFoodStatisticsMealMostEaten = new System.Windows.Forms.Label();
            this.lblFood2 = new System.Windows.Forms.Label();
            this.lblFood3 = new System.Windows.Forms.Label();
            this.lblFood4 = new System.Windows.Forms.Label();
            this.lblFood5 = new System.Windows.Forms.Label();
            this.btnFoodStatisticsUpdate = new System.Windows.Forms.Button();
            this.lblMostEatenFood = new System.Windows.Forms.Label();
            this.lblMostEatenBreakfast = new System.Windows.Forms.Label();
            this.lblMostEatenLunch = new System.Windows.Forms.Label();
            this.lblMostEatenDinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFood1
            // 
            this.lblFood1.AutoSize = true;
            this.lblFood1.Location = new System.Drawing.Point(12, 20);
            this.lblFood1.Name = "lblFood1";
            this.lblFood1.Size = new System.Drawing.Size(94, 13);
            this.lblFood1.TabIndex = 2;
            this.lblFood1.Text = "Most Eaten Food :";
            // 
            // lblFoodStatisticsMealMostEaten
            // 
            this.lblFoodStatisticsMealMostEaten.AutoSize = true;
            this.lblFoodStatisticsMealMostEaten.Location = new System.Drawing.Point(454, 45);
            this.lblFoodStatisticsMealMostEaten.Name = "lblFoodStatisticsMealMostEaten";
            this.lblFoodStatisticsMealMostEaten.Size = new System.Drawing.Size(0, 13);
            this.lblFoodStatisticsMealMostEaten.TabIndex = 3;
            // 
            // lblFood2
            // 
            this.lblFood2.AutoSize = true;
            this.lblFood2.Location = new System.Drawing.Point(12, 59);
            this.lblFood2.Name = "lblFood2";
            this.lblFood2.Size = new System.Drawing.Size(133, 13);
            this.lblFood2.TabIndex = 4;
            this.lblFood2.Text = "Most Eaten Food in Meals:";
            // 
            // lblFood3
            // 
            this.lblFood3.AutoSize = true;
            this.lblFood3.Location = new System.Drawing.Point(12, 100);
            this.lblFood3.Name = "lblFood3";
            this.lblFood3.Size = new System.Drawing.Size(55, 13);
            this.lblFood3.TabIndex = 7;
            this.lblFood3.Text = "Breakfast:";
            // 
            // lblFood4
            // 
            this.lblFood4.AutoSize = true;
            this.lblFood4.Location = new System.Drawing.Point(12, 136);
            this.lblFood4.Name = "lblFood4";
            this.lblFood4.Size = new System.Drawing.Size(40, 13);
            this.lblFood4.TabIndex = 8;
            this.lblFood4.Text = "Lunch:";
            // 
            // lblFood5
            // 
            this.lblFood5.AutoSize = true;
            this.lblFood5.Location = new System.Drawing.Point(11, 164);
            this.lblFood5.Name = "lblFood5";
            this.lblFood5.Size = new System.Drawing.Size(41, 13);
            this.lblFood5.TabIndex = 9;
            this.lblFood5.Text = "Dinner:";
            // 
            // btnFoodStatisticsUpdate
            // 
            this.btnFoodStatisticsUpdate.Location = new System.Drawing.Point(30, 207);
            this.btnFoodStatisticsUpdate.Name = "btnFoodStatisticsUpdate";
            this.btnFoodStatisticsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFoodStatisticsUpdate.TabIndex = 10;
            this.btnFoodStatisticsUpdate.Text = "Update";
            this.btnFoodStatisticsUpdate.UseVisualStyleBackColor = true;
            this.btnFoodStatisticsUpdate.Click += new System.EventHandler(this.btnFoodStatisticsUpdate_Click);
            // 
            // lblMostEatenFood
            // 
            this.lblMostEatenFood.AutoSize = true;
            this.lblMostEatenFood.Location = new System.Drawing.Point(128, 20);
            this.lblMostEatenFood.Name = "lblMostEatenFood";
            this.lblMostEatenFood.Size = new System.Drawing.Size(0, 13);
            this.lblMostEatenFood.TabIndex = 11;
            // 
            // lblMostEatenBreakfast
            // 
            this.lblMostEatenBreakfast.AutoSize = true;
            this.lblMostEatenBreakfast.Location = new System.Drawing.Point(89, 100);
            this.lblMostEatenBreakfast.Name = "lblMostEatenBreakfast";
            this.lblMostEatenBreakfast.Size = new System.Drawing.Size(0, 13);
            this.lblMostEatenBreakfast.TabIndex = 13;
            // 
            // lblMostEatenLunch
            // 
            this.lblMostEatenLunch.AutoSize = true;
            this.lblMostEatenLunch.Location = new System.Drawing.Point(70, 136);
            this.lblMostEatenLunch.Name = "lblMostEatenLunch";
            this.lblMostEatenLunch.Size = new System.Drawing.Size(0, 13);
            this.lblMostEatenLunch.TabIndex = 14;
            // 
            // lblMostEatenDinner
            // 
            this.lblMostEatenDinner.AutoSize = true;
            this.lblMostEatenDinner.Location = new System.Drawing.Point(70, 164);
            this.lblMostEatenDinner.Name = "lblMostEatenDinner";
            this.lblMostEatenDinner.Size = new System.Drawing.Size(0, 13);
            this.lblMostEatenDinner.TabIndex = 15;
            // 
            // FoodStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 311);
            this.Controls.Add(this.lblMostEatenDinner);
            this.Controls.Add(this.lblMostEatenLunch);
            this.Controls.Add(this.lblMostEatenBreakfast);
            this.Controls.Add(this.lblMostEatenFood);
            this.Controls.Add(this.btnFoodStatisticsUpdate);
            this.Controls.Add(this.lblFood5);
            this.Controls.Add(this.lblFood4);
            this.Controls.Add(this.lblFood3);
            this.Controls.Add(this.lblFood2);
            this.Controls.Add(this.lblFoodStatisticsMealMostEaten);
            this.Controls.Add(this.lblFood1);
            this.Name = "FoodStatisticsForm";
            this.Text = "FoodStatisticsForm";
            this.Load += new System.EventHandler(this.FoodStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFood1;
        private System.Windows.Forms.Label lblFoodStatisticsMealMostEaten;
        private System.Windows.Forms.Label lblFood2;
        private System.Windows.Forms.Label lblFood3;
        private System.Windows.Forms.Label lblFood4;
        private System.Windows.Forms.Label lblFood5;
        private System.Windows.Forms.Button btnFoodStatisticsUpdate;
        private System.Windows.Forms.Label lblMostEatenFood;
        private System.Windows.Forms.Label lblMostEatenBreakfast;
        private System.Windows.Forms.Label lblMostEatenLunch;
        private System.Windows.Forms.Label lblMostEatenDinner;
    }
}