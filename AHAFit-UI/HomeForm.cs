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
    public partial class HomeForm : Form
    {
        private readonly int memberId;
        public HomeForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            cmbMealSumCalorie.DataSource = Huseyin.GetMeals();
            cmbMealSumCalorie.SelectedIndex = 0;
            FoodListFill();
            dtpHomeDate.MinDate = new DateTime(2020, 1, 1);
            dtpHomeDate.MaxDate = DateTime.Today;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(memberId);
            reportsForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(memberId);
            historyForm.Show();
        }

        private void btnMemberComp_Click(object sender, EventArgs e)
        {
            MemberCompForm memberCompForm = new MemberCompForm(memberId);
            memberCompForm.Show();
        }

        private void btnFoodSt_Click(object sender, EventArgs e)
        {
            FoodStatisticsForm foodStatisticsForm = new FoodStatisticsForm(memberId);
            foodStatisticsForm.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMICalcForm bMICalcForm = new BMICalcForm(memberId);
            bMICalcForm.Show();
        }

        private void dtpHomeDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshHomeData();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblMotivation.Text = "Welcome " + Huseyin.GetMemberName(memberId) + ". " + getMotivation();
            dtpHomeDate.Value = DateTime.Today;            
           
        }

        private string getMotivation()
        {
            List<string> motivationWords = new List<string>()
            {
                "Believe in yourself.",
                "Work hard.",
                "Don’t wait.",
                "Step outside your comfort zone.",
                "Be a dreamer and a doer.",
                "Take action.",
                "Don’t give up.",
                "Set big goals.",
                "Follow through.",
                "Show up every day.",
                "Make things happen for yourself.",
                "Celebrate the small things.",
                "Take one step at a time.",
                "Open doors for yourself.",
                "Push through and understand yourself.",
                "Stick to the plan.",
                "Say yes to your dreams."
            };

            Random rnd = new Random();
            int selectedMotivation = rnd.Next(0, motivationWords.Count - 1);

            return motivationWords[selectedMotivation];

        }

        private void cmbMealSumCalorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMealSumCalorie.Text = Huseyin.DailyCalorieCalculaterAccordingToMeal(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text).ToString() + " Calories";
        }

        private void FoodListFill()
        {
            dgvDailyFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDailyFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDailyFoodList.MultiSelect = false;

            dgvDailyFoodList.Rows.Clear();
            dgvDailyFoodList.Refresh();

            List<Food> foodList = Huseyin.DailyFoods(memberId, dtpHomeDate.Value.Date);

            foreach (var food in foodList)
            {
                dgvDailyFoodList.Columns[0].Name = "Food Name";
                dgvDailyFoodList.Columns[1].Name = "Calorie";
                dgvDailyFoodList.Columns[2].Name = "Carbohydrate";
                dgvDailyFoodList.Columns[3].Name = "Protein";
                dgvDailyFoodList.Columns[4].Name = "Fat";
                dgvDailyFoodList.Columns[5].Name = "FoodId";
               
                string[] row = new string[] { food.Name, food.Calorie.ToString(), food.Carbohydrate.ToString(), food.Protein.ToString(), food.Fat.ToString(), food.FoodId.ToString()};
              
                dgvDailyFoodList.Rows.Add(row);

            }

           
        }

        private void dgvDailyFoodList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvDailyFoodList.HitTest(e.X, e.Y);
                dgvDailyFoodList.ClearSelection();
                if(hti.RowIndex != -1)
                {
                    dgvDailyFoodList.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dgvDailyFoodList.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if(rowToDelete>=0)
            {
                int foodIdToDelete = Convert.ToInt32(dgvDailyFoodList.Rows[rowToDelete].Cells[5].Value);

                Huseyin.MemberFoodRemevoFromDB(dtpHomeDate.Value.Date, memberId, foodIdToDelete);
                FoodListFill();
            }
            

        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            Huseyin.plusOneGlassOfWater(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text);
            FoodListFill();
            lblRemainWater.Text = "You should drink " + (Huseyin.DailyRemainWater(memberId, dtpHomeDate.Value.Date)).ToString() + " more glasses of water today.";
        }

        private void btnProgramChanger_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Cursor.Position);
        }

        private void loseWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huseyin.ChangeMembersGoal(memberId, sender.ToString());
            RefreshHomeData();
        }

        private void RefreshHomeData()
        {
            lblSumCalorie.Text = (Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString() + " Calories Eaten Today";
            lblRemainWater.Text = "You should drink " + (Huseyin.DailyRemainWater(memberId, dtpHomeDate.Value.Date)).ToString() + " more glasses of water today.";
            lblRemainCalorie.Text = (Huseyin.CalculateDailyCalorieNeed(memberId) - Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString() + " Calories left for today.";
            lblCarbo.Text = Huseyin.DailyCarbohydrate(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblPro.Text = Huseyin.DailyProtein(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblFat.Text = Huseyin.DailyFat(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblMealSumCalorie.Text = Huseyin.DailyCalorieCalculaterAccordingToMeal(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text).ToString() + " Calories";
            lblDateText.Text = dtpHomeDate.Value.Date.ToString("dd MMMM yyyy") + " Calorie List";
            FoodListFill();
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            ProfileUpdateForm newProfileUpdateForm = new ProfileUpdateForm(memberId);
            newProfileUpdateForm.Show();
            RefreshHomeData();
        }

        private void btnAteSomething_Click(object sender, EventArgs e)
        {
            AddDailyFoodForm newAddDailyFoodForm = new AddDailyFoodForm(memberId);
            newAddDailyFoodForm.Show();
            RefreshHomeData();
        }
    }
}
