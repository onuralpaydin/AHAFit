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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;

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
            this.Width = 1150;
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
            DesignChanges();
            

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
                dgvDailyFoodList.Columns[6].Name = "FoodType";
               
                string[] row = new string[] { food.Name, food.Calorie.ToString(), food.Carbohydrate.ToString(), food.Protein.ToString(), food.Fat.ToString(), food.FoodId.ToString(), food.FoodType.ToString()};
              
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
                RefreshHomeData();
            }
            

        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            Huseyin.plusOneGlassOfWater(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text);
            FoodListFill();
            RefreshHomeData();
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
            lblSumCalorie.Text = (Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date)).ToString() + " Cal";

            if(Huseyin.DailyRemainWater(memberId, dtpHomeDate.Value.Date) > 0)
            {
                lblRemainWater.Text = "You should drink " + (Huseyin.DailyRemainWater(memberId, dtpHomeDate.Value.Date)).ToString() + " more glasses of water today.";
            }else
            {
                lblRemainWater.Text = "You drank enough water today.";
            }
            lblRemainCalorie.Text = Math.Round(((Huseyin.CalculateDailyCalorieNeed(memberId) - Huseyin.DailyCalorieCalculater(memberId, dtpHomeDate.Value.Date))),2).ToString() + " Cal";
            lblCarbo.Text = Huseyin.DailyCarbohydrate(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblPro.Text = Huseyin.DailyProtein(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblFat.Text = Huseyin.DailyFat(memberId, dtpHomeDate.Value.Date).ToString() + " gr";
            lblMealSumCalorie.Text = Huseyin.DailyCalorieCalculaterAccordingToMeal(memberId, dtpHomeDate.Value.Date, cmbMealSumCalorie.Text).ToString() + " Calories";
            lblDateText.Text = dtpHomeDate.Value.Date.ToString("dd MMMM yyyy");
            FoodListFill();
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnlMain.Controls)
            {
                if (item != pnlHome)
                    pnlMain.Controls.Remove(item);
            }
            pnlHome.Visible = false;
            ProfileUpdateForm newProfileUpdateForm = new ProfileUpdateForm(memberId);
            newProfileUpdateForm.MdiParent = this;
            newProfileUpdateForm.Dock = DockStyle.Fill;
            newProfileUpdateForm.BackColor = Color.FromArgb(168, 181, 191);
            pnlMain.Controls.Add(newProfileUpdateForm);
            newProfileUpdateForm.Show();
            RefreshHomeData();
        }

        private void btnAteSomething_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;

            foreach (Control item in pnlMain.Controls)
            {
                if (item != pnlHome)
                    pnlMain.Controls.Remove(item);
            }
            AddDailyFoodForm newAddDailyFoodForm = new AddDailyFoodForm(memberId);
            newAddDailyFoodForm.MdiParent = this;
            newAddDailyFoodForm.Dock = DockStyle.Fill;
            newAddDailyFoodForm.BackColor = Color.FromArgb(168, 181, 191);
            pnlMain.Controls.Add(newAddDailyFoodForm);
            newAddDailyFoodForm.Show();
            RefreshHomeData();
        }

        private void DesignChanges()
        {
          
            flwPnlLeftSide.BackColor = Color.FromArgb(46, 65, 89);
            btnHome.BackColor = Color.FromArgb(168, 181, 191);
            btnHistory.BackColor = Color.FromArgb(168, 181, 191);
            btnBMI.BackColor = Color.FromArgb(168, 181, 191);
            btnFoodSt.BackColor = Color.FromArgb(168, 181, 191);
            btnMemberComp.BackColor = Color.FromArgb(168, 181, 191);
            pnlTop.BackColor = Color.FromArgb(166, 83, 105);
            pnlMain.BackColor = Color.FromArgb(168, 181, 191);
            pnlDailyCalorie.BackColor = Color.FromArgb(92, 98, 115);
            pnlEatenToday.BackColor = Color.FromArgb(92, 98, 115);
            pnlBasedOnMeals.BackColor = Color.FromArgb(92, 98, 115);

            btnWater.BackColor = Color.FromArgb(166, 83, 105);
            btnAteSomething.BackColor = Color.FromArgb(166, 83, 105);
            btnProgramChanger.BackColor = Color.FromArgb(166, 83, 105);
            btnProfileUpdate.BackColor = Color.FromArgb(166, 83, 105);

            dgvDailyFoodList.BackgroundColor = Color.FromArgb(168, 181, 191);
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlResizeRight_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void pnlResizeRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void pnlResizeRight_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            pnlHome.Visible = true;
            FoodListFill();
            RefreshHomeData();
        }
    }
}
