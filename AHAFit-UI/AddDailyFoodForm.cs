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
        FoodMemberData FoodMemberData = new FoodMemberData();
        MealFoodData MealFoodData = new MealFoodData();
        private readonly int memberId;

        public AddDailyFoodForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            fillComboBoxes();
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.MultiSelect = false;
            dgvFoods.AllowUserToAddRows = false;
            DesignSettings();
            dtpEatDate.MinDate = new DateTime(2020, 1, 1);
            dtpEatDate.MaxDate = DateTime.Today;
        }

        private void AddDailyFoodForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFoodSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNewFoodName.Text) && !string.IsNullOrEmpty(txtPhotoUrl.Text))
            {
                MealFoodData.AddNewFood(txtNewFoodName.Text, Convert.ToDouble(nudCalorie.Value), Convert.ToDouble(nudCarbohydrate.Value), Convert.ToDouble(nudProtein.Value), Convert.ToDouble(nudFat.Value), txtPhotoUrl.Text, cmbFoodType.Text);
                MessageBox.Show("The food has been successfully saved.");
                txtNewFoodName.Clear();
                txtPhotoUrl.Clear();
            }else
            {
                MessageBox.Show("Please fill in all the blanks.");
            }
        }

        private void fillComboBoxes()
        {
            cmbEatMeal.DataSource = MealFoodData.GetMeals();
            cmbEatMeal.SelectedIndex = 0;
            foreach (var foodType in (FoodType[])Enum.GetValues(typeof(FoodType)))
            {
                cmbFoodType.Items.Add(foodType);
            }
            cmbFoodType.SelectedIndex = 0;
        }

        private void txtFoodSearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Food> foodList = new List<Food>();

            dgvFoods.Rows.Clear();
            dgvFoods.Refresh();

            foodList = MealFoodData.FindTheFood(txtFoodSearchBox.Text.ToLower());

            foreach (var food in foodList)
            {
                dgvFoods.Columns[0].Name = "FoodId";
                dgvFoods.Columns[1].Name = "FoodName";
                dgvFoods.Columns[2].Name = "Calorie";
                dgvFoods.Columns[3].Name = "Carbohydrate";
                dgvFoods.Columns[4].Name = "Protein";
                dgvFoods.Columns[5].Name = "Fat";
                dgvFoods.Columns[6].Name = "FoodType";

                string[] row = new string[] { food.FoodId.ToString(),food.Name, food.Calorie.ToString(), food.Carbohydrate.ToString(), food.Protein.ToString(), food.Fat.ToString(), food.FoodType  };

                dgvFoods.Rows.Add(row);

                int selectedRow = dgvFoods.Rows.GetFirstRow(DataGridViewElementStates.Selected);

                pbFood.ImageLocation = MealFoodData.FindFoodImageUrl(FindSelectedFoodId());
            }
        }

        private void btnCheckImage_Click(object sender, EventArgs e)
        {
            if(txtPhotoUrl.Text.Contains("http"))
            {
                pbFood.ImageLocation = txtPhotoUrl.Text;
                
            }else
            {
                MessageBox.Show("Image link not working.");
                pbFood.ImageLocation = null;
                txtPhotoUrl.Clear();
                pbFood.Update();
            }
        }

        private void btnSaveEat_Click(object sender, EventArgs e)
        {
            FoodMemberData.AddNewFoodToMember(FindSelectedFoodId(), dtpEatDate.Value.Date, memberId, MealFoodData.FindMealId(cmbEatMeal.Text));
        }

        private int FindSelectedFoodId()
        {
            int selectedFoodId = 0;
            int selectedRow = dgvFoods.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (selectedRow >= 0)
            {
                selectedFoodId = Convert.ToInt32(dgvFoods.Rows[selectedRow].Cells[0].Value);
            }
            return selectedFoodId;
        }

        private void DesignSettings()
        {
            btnCheckImage.BackColor = Color.FromArgb(166, 83, 105);
            btnNewFoodSave.BackColor = Color.FromArgb(166, 83, 105);
            btnSaveEat.BackColor = Color.FromArgb(166, 83, 105);
            dgvFoods.BackgroundColor = Color.FromArgb(168, 181, 191);
        }

        private void dgvFoods_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvFoods.HitTest(e.X, e.Y);
                dgvFoods.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dgvFoods.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MealFoodData.FoodDelete(FindSelectedFoodId());
            txtFoodSearchBox.Text += " ";
            txtFoodSearchBox.Text = txtFoodSearchBox.Text.Remove(0, 1);
        }

        private void pbFood_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Image link not working.");
                txtPhotoUrl.Text = "";
                pbFood.ImageLocation = null;
                pbFood.Image = null;
            }
        }
    }
}
