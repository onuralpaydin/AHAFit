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
    public partial class AddDailyFoodForm : Form
    {
        private readonly int memberId;

        public AddDailyFoodForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            fillComboBoxes();
        }

        private void AddDailyFoodForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFoodSave_Click(object sender, EventArgs e)
        {
            Huseyin.AddNewFood(txtNewFoodName.Text, Convert.ToDouble(nudCalorie.Value), Convert.ToDouble(nudCarbohydrate.Value), Convert.ToDouble(nudProtein.Value), Convert.ToDouble(nudFat.Value), txtPhotoUrl.Text, cmbFoodType.Text);
        }

        private void fillComboBoxes()
        {
            cmbEatMeal.DataSource = Huseyin.GetMeals();
            cmbEatMeal.SelectedIndex = 0;
            foreach (var foodType in (FoodType[])Enum.GetValues(typeof(FoodType)))
            {
                cmbFoodType.Items.Add(foodType);
            }
            cmbFoodType.SelectedIndex = 0;
        }

        private void txtFoodSearchBox_TextChanged(object sender, EventArgs e)
        {
           dgvFoods.DataSource = Huseyin.FindTheFood(txtFoodSearchBox.Text.ToLower());
        }

        private void btnCheckImage_Click(object sender, EventArgs e)
        {
            pbFood.ImageLocation = txtPhotoUrl.Text;
        }
    }
}
