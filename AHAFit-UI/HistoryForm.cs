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
    public partial class HistoryForm : Form
    {

        FoodMemberData FoodMemberData = new FoodMemberData();
              
        private readonly int memberId;

        public HistoryForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            dgvHistory.BackgroundColor = Color.FromArgb(168, 181, 191);
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            btnAll.BackColor = Color.FromArgb(166, 83, 105);
            btnMonthly.BackColor = Color.FromArgb(166, 83, 105);
            btnWeekly.BackColor = Color.FromArgb(166, 83, 105);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FoodListFill(0);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dgvHistory.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (rowToDelete >= 0)
            {
                int foodIdToDelete = Convert.ToInt32(dgvHistory.Rows[rowToDelete].Cells[0].Value);
                var foodDateToDelete = dgvHistory.Rows[rowToDelete].Cells[1].Value.ToString();
                
                FoodMemberData.MemberFoodRemevoFromDB(DateTime.Parse(foodDateToDelete), memberId, foodIdToDelete);
                dgvHistory.Rows.RemoveAt(rowToDelete);
                MessageBox.Show("The food has been successfully deleted from your list.");
            }
        }


        private void FoodListFill(int daysBack)
        {
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.MultiSelect = false;

            dgvHistory.Rows.Clear();
            dgvHistory.Refresh();

            var foodAndDateList = FoodMemberData.MemberFoodsAccordingToDate(memberId, daysBack).First();
            int i = 0;
            foreach (var food in foodAndDateList.Key)
            {
                dgvHistory.Columns[0].Name = "FoodId";
                dgvHistory.Columns[1].Name = "Eating Date";
                dgvHistory.Columns[2].Name = "Food Name";
                dgvHistory.Columns[3].Name = "Calorie";
                dgvHistory.Columns[4].Name = "Carbohydrate";
                dgvHistory.Columns[5].Name = "Protein";
                dgvHistory.Columns[6].Name = "Fat";
                dgvHistory.Columns[7].Name = "FoodType";

                string[] row = new string[] { food.FoodId.ToString(), foodAndDateList.Value[i++].Date.ToString(), food.Name, food.Calorie.ToString(), food.Carbohydrate.ToString(), food.Protein.ToString(), food.Fat.ToString(), food.FoodType.ToString() };

                dgvHistory.Rows.Add(row);
            }
        }

        private void dgvHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvHistory.HitTest(e.X, e.Y);
                dgvHistory.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dgvHistory.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            FoodListFill(30);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            FoodListFill(7);
        }
    }
}
