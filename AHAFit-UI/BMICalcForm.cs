using AHAFit_BLL;
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
        Alper alper;
        public BMICalcForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;     
            alper = new Alper(memberId);      
            
        }
        private void BMICalcForm_Load(object sender, EventArgs e)
        {
            var x = alper.BMIUser();
            for (int i = 0; i < x.Count; i++)
            {
                txtUserName.Text = x[0].ToString();
                txtHeight.Text = x[1].ToString();
                txtWeight.Text = x[2].ToString();
            }
            BMICalculate();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHeight.Text)&&!string.IsNullOrEmpty(txtWeight.Text))
            {
                BMICalculate();
            }
            else
            {
                MessageBox.Show("Empty spaces left,check your entries");
            }
        }

         private void BMICalculate()
        {
            
            if (alper.BMIEntryCheck(txtWeight.Text,txtHeight.Text))
            {
                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double bmi = alper.BMIValue(weight, height);
                txtBMI.Text = bmi.ToString();
                try
                {
                    tbBmi.Value = (int)bmi * 10;
                }
                catch
                {
                    tbBmi.Value = 400;                    
                }
            }
            else
                MessageBox.Show("Entries must be numeric input");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBMI.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            tbBmi.Value=0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       
    }
}
