using AHAFit_Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AHAFit_UI
{
    public partial class BMICalcForm : Form
    {
        private readonly int memberId;
        Context db = new Context();
        public BMICalcForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;     
            
        }
        private void BMICalcForm_Load(object sender, EventArgs e)
        {
            var user = db.Members.Where(u => u.MemberId == memberId).ToList();
            foreach (var prop in user)
            {
                txtHeight.Text = prop.Height.ToString();
                txtWeight.Text = prop.Weight.ToString();
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHeight.Text)&&!string.IsNullOrEmpty(txtWeight.Text))
            {
                double weight, height;                
                bool isWeight = double.TryParse(txtWeight.Text, out weight);
                bool isHeight = double.TryParse(txtHeight.Text, out height);
                if (isWeight && isHeight)
                {
                    double bmi = Math.Round((weight / Math.Pow(height, 2)*10000),2);
                    try
                    {
                        tbBmi.Value = (int)bmi * 10;
                    }
                    catch 
                    {

                        tbBmi.Value = 400;
                    }                    
                    txtBMI.Text=bmi.ToString();
                }
                else
                    MessageBox.Show("Entries must be numeric input");
            }
            else
            {
                MessageBox.Show("Empty spaces left,check your entries");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBMI.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            tbBmi.Value=0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
