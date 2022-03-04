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
    public partial class ReportsForm : Form
    {
        private readonly int memberId;

        public ReportsForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }         
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            #region Combobox Loads
            Alper alper = new Alper(memberId);
            foreach (var item in alper.Categories())
            {
                cmbCategories.Items.Add(item);
            }
            cmbCategories.SelectedIndex = 0;
            foreach (var item in alper.Meals())
            {
                cmbMeals.Items.Add(item);
            }
            cmbMeals.SelectedIndex = 0;
            #endregion                                   
        }
        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alper alper = new Alper(memberId);
            if (cmbMeals.SelectedIndex == 0)
            {
                AverageCalorieCalculator(alper);
            }
            else if (cmbMeals.SelectedIndex == 1)
            {
                AverageCalorieCalculator(alper);
            }
            else if (cmbMeals.SelectedIndex == 2)
            {
                AverageCalorieCalculator(alper);
            }
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alper alper = new Alper(memberId);
            if (cmbCategories.SelectedItem.ToString() != null)
            {
                AverageCalorieCalculatorByCategorie(alper);
            }          

        }
        private void AverageCalorieCalculator(Alper alper)
        {
            if (rdbWeekly.Checked)
            {
                lblCalorie.Text = alper.ReportsFormCalorieMember(cmbMeals.SelectedIndex + 1, -7).ToString();
                lblTotalCalorie.Text = alper.ReportsFormCalorieAllMembers(cmbMeals.SelectedIndex + 1, -7).ToString();
            }
            else if (rdbMonthly.Checked)
            {
                lblCalorie.Text = alper.ReportsFormCalorieMember(cmbMeals.SelectedIndex + 1, -30).ToString();
                lblTotalCalorie.Text = alper.ReportsFormCalorieAllMembers(cmbMeals.SelectedIndex + 1, -30).ToString();
            }
        }
        private void AverageCalorieCalculatorByCategorie(Alper alper)
        {
            if (rdbWeekly.Checked)
            {
                lblCalorie.Text = alper.ReportsFormCalorieMemberByCategorie(memberId, cmbCategories.SelectedItem.ToString(), -7).ToString();
                lblTotalCalorie.Text = alper.ReportsFormCalorieAllMembersByCategorie(cmbCategories.SelectedItem.ToString(), -7).ToString();
            }
            else if (rdbMonthly.Checked)
            {
                lblCalorie.Text = alper.ReportsFormCalorieMemberByCategorie(memberId, cmbCategories.SelectedItem.ToString(), -30).ToString();
                lblTotalCalorie.Text = alper.ReportsFormCalorieAllMembersByCategorie(cmbCategories.SelectedItem.ToString(), -30).ToString();
            }
        }
    }
}
