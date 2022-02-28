using AHAFit_BLL;
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
            cmbEatMeal.DataSource = Huseyin.GetMeals();
            cmbMealNewFood.DataSource = Huseyin.GetMeals();
            cmbEatMeal.SelectedIndex = 0;
            cmbMealNewFood.SelectedIndex = 0;
        }

        private void AddDailyFoodForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFoodSave_Click(object sender, EventArgs e)
        {
            Huseyin.AddNewFood(txtNewFoodName.Text, Convert.ToDouble(nudCalorie.Value), Convert.ToDouble(nudCarbohydrate), Convert.ToDouble(nudProtein), Convert.ToDouble(nudFat), txtPhotoUrl.Text);
        }
    }
}
