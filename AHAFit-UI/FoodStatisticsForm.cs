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
    public partial class FoodStatisticsForm : Form
    {
        private readonly int memberId;
        Onur onur = new Onur();

        public FoodStatisticsForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            
        }

        private void FoodStatisticsForm_Load(object sender, EventArgs e)
        {
            dgvFoodStatisticsMostEaten.DataSource = onur.MostEatenFood(memberId);
            //dgvFoodStatisticsMealMost.DataSource = onur.MealMostEatenFood(memberId);
            MessageBox.Show(onur.MostEatenFood(memberId).First().Key+" "+ onur.MostEatenFood(memberId).First().Value);

        }
    }
}
