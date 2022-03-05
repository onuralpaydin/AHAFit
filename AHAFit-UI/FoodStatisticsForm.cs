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
            lblMostEatenFood.Text = onur.MostEatenFood(memberId).First().Key + " " + onur.MostEatenFood(memberId).First().Value;
            lblMostEatenBreakfast.Text=onur.MostEatenFoodBreakfast(memberId).First().Key + " " + onur.MostEatenFoodBreakfast(memberId).First().Value;
            lblMostEatenLunch.Text = onur.MostEatenFoodLunch(memberId).First().Key + " " + onur.MostEatenFoodLunch(memberId).First().Value;
            lblMostEatenDinner.Text = onur.MostEatenFoodDinner(memberId).First().Key + " " + onur.MostEatenFoodDinner(memberId).First().Value;



        }

        private void btnFoodStatisticsUpdate_Click(object sender, EventArgs e)
        {
            //mdi formdan dolayı otomatik güncelleme yapıyor.Eğer ki yemek yedim dedikten sonra foodstatistics sayfasını kapatmazsan update butonu ile güncelleme çalışıyor.
            lblMostEatenFood.Text = "";
            lblMostEatenBreakfast.Text = "";
            lblMostEatenLunch.Text = "";
            lblMostEatenDinner.Text = "";

            lblMostEatenFood.Text = onur.MostEatenFood(memberId).First().Key + " " + onur.MostEatenFood(memberId).First().Value;
            lblMostEatenBreakfast.Text = onur.MostEatenFoodBreakfast(memberId).First().Key + " " + onur.MostEatenFoodBreakfast(memberId).First().Value;
            lblMostEatenLunch.Text = onur.MostEatenFoodLunch(memberId).First().Key + " " + onur.MostEatenFoodLunch(memberId).First().Value;
            lblMostEatenDinner.Text = onur.MostEatenFoodDinner(memberId).First().Key + " " + onur.MostEatenFoodDinner(memberId).First().Value;
        }
    }
}
