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
            lblSumCalorie.Text = (Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString();
        }


    }
}
