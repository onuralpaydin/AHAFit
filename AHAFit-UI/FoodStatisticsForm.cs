using AHAFit_BLL;
using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHAFit_UI
{
    public partial class FoodStatisticsForm : Form
    {
        string selectedTime = "";
        string meal = "";
        private readonly int memberId;
        MealFoodData MealFoodData = new MealFoodData();

        public FoodStatisticsForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            cmbMeals.Items.Add("All Meals");
            foreach (var item in MealFoodData.GetMeals())
            {
                cmbMeals.Items.Add(item);
            }
            cmbCategories.Items.Add("All Types");
            foreach (var foodType in (FoodType[])Enum.GetValues(typeof(FoodType)))
            {
                cmbCategories.Items.Add(foodType);
            }
        }

        private void FoodStatisticsForm_Load(object sender, EventArgs e)
        {
            cmbMeals.SelectedIndex = 0;
            rdoAll.Checked = true;
            cmbCategories.SelectedIndex = 0;
            btnFoodStatisticsUpdate.BackColor = Color.FromArgb(166, 83, 105);
        }

        private void btnFoodStatisticsUpdate_Click(object sender, EventArgs e)
        {
            var daysBack = 0;
            switch (selectedTime)
            {
                case "rdoAll":
                    daysBack = 0;
                    break;
                case "rdoMonthly":
                    daysBack = 30;
                    break;
                case "rdoWeekly":
                    daysBack = 7;
                    break;
            }

            var mealId = 0;
            switch (meal)
            {
                case "All Meals":
                    mealId = 0;
                    break;
                case "Breakfast":
                    mealId = MealFoodData.FindMealId("Breakfast");
                    break;
                case "Lunch":
                    mealId = MealFoodData.FindMealId("Lunch");
                    break;
                case "Dinner":
                    mealId = MealFoodData.FindMealId("Dinner");
                    break;
            }

            pictureBox1.ImageLocation = "";
            if(MealFoodData.MostEatenFood(memberId, daysBack, mealId, cmbCategories.Text).First().Value == 0)
            {
                MessageBox.Show("Not Enough Data");
                lblMostEaten.Text = "Not Enough Data";
                lblTotalCal.Text = "Not Enough Data";
            }
            else
            {
                var result = MealFoodData.MostEatenFood(memberId, daysBack, mealId, cmbCategories.Text);
                lblMostEaten.Text = result.FirstOrDefault(x => x.Key != "Total Cal").Key + ". You ate " + result.FirstOrDefault(x => x.Key != "Total Cal").Value + " times in total.";
                lblTotalCal.Text = String.Format("{0:n}", result.FirstOrDefault(x => x.Key == "Total Cal").Value);
                pictureBox1.ImageLocation = MealFoodData.FindFoodImageUrlviaName(result.First().Key);
            }
           
        }

        private void rdoWeekly_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    selectedTime = rb.Name;
                }
            }
        }

        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            meal = cmbMeals.Text;
        }

    }
}
