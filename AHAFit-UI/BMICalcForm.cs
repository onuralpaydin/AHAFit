using AHAFit_BLL;
using AHAFit_Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AHAFit_UI
{
    public partial class BMICalcForm : Form
    {
        MemberData MemberData = new MemberData();
        private readonly int memberId;

        public BMICalcForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;        
        }
        private void BMICalcForm_Load(object sender, EventArgs e)
        {
            var bmi = MemberData.BmiCalculator(memberId);
            pnl1.BackColor = Color.FromArgb(255, 193, 7);
            lblYourBMIUnder.BackColor = Color.FromArgb(255, 193, 7);
            pnl2.BackColor = Color.FromArgb(139, 195, 74);
            lblYourBMIHealty.BackColor = Color.FromArgb(139, 195, 74);
            pnl3.BackColor = Color.FromArgb(255, 167, 38);
            lblYourBMIOver.BackColor = Color.FromArgb(255, 167, 38);
            pnl4.BackColor = Color.FromArgb(239, 108, 0);
            lblYourBMIObese.BackColor = Color.FromArgb(239, 108, 0);
            pnl5.BackColor = Color.FromArgb(198, 40, 40);
            lblYourBMIMorbi.BackColor = Color.FromArgb(198, 40, 40);

            lblPersonalBMI.Text = String.Format("{0:n}", MemberData.BmiCalculator(memberId));
            
            lblYourBMIUnder.Visible = false;
            lblYourBMIHealty.Visible = false;
            lblYourBMIOver.Visible = false;
            lblYourBMIObese.Visible = false;
            lblYourBMIMorbi.Visible = false;

            lblIdealWeighRange.Text = MemberData.HealtyGap(memberId);
            lblCurrentWeight.Text = MemberData.MemberCurrentWeigh(memberId);

            lblLine1.Text = MemberData.BMILineValues(memberId, 1);
            lblLine2.Text = MemberData.BMILineValues(memberId, 2);
            lblLine3.Text = MemberData.BMILineValues(memberId, 3);
            lblLine4.Text = MemberData.BMILineValues(memberId, 4);

            string text = $"Your BMI@{lblPersonalBMI.Text}";
            text = text.Replace("@", "" + System.Environment.NewLine);

            if (bmi < 18.5)
            {
                lblYourBMIUnder.Visible = true;
                lblYourBMIUnder.Text = text;
            }else if(bmi>=18.5 && bmi < 25)
            {
                lblYourBMIHealty.Visible = true;
                lblYourBMIHealty.Text = text;
            }else if (bmi >= 25 && bmi < 30)
            {
                lblYourBMIOver.Text = text;
                lblYourBMIOver.Visible = true;
            }
            else if (bmi >= 30 && bmi < 40)
            {
                lblYourBMIObese.Text = text;
                lblYourBMIObese.Visible = true;
            }
            else if (bmi >= 40)
            {
                lblYourBMIMorbi.Text = text;
                lblYourBMIMorbi.Visible = true;
            }

        }
   
    }
}
