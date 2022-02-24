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
    public partial class HomeForm : Form
    {
        private readonly int memberId;

        public HomeForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
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
            lblSumCalorie.Text = (Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString() + " Calories Eaten Today";
            lblRemainWater.Text = "You should drink " + (Huseyin.DailyRemainWater(memberId, dtpHomeDate.Value.Date)).ToString() + " more glasses of water today.";
            lblRemainCalorie.Text = (Huseyin.CalculateDailyCalorieNeed(memberId) - Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString() + " Calories left for today.";
            lblCarbo.Text = Huseyin.DailyCarbohydrate(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblPro.Text = Huseyin.DailyProtein(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblFat.Text = Huseyin.DailyFat(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblMealSumCalorie.Text = Huseyin.DailyCalorieCalculaterAccordingToMeal(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text).ToString() + " Calories";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblMotivation.Text = "Welcome " + Huseyin.GetMemberName(memberId) + ". " + getMotivation();
            dtpHomeDate.Value = DateTime.Now;
            cmbMealSumCalorie.DataSource = Huseyin.GetMeals();
            cmbMealSumCalorie.SelectedIndex = 0;

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
    }
}
