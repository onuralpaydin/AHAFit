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
        
        Onur onur = new Onur();
        
       
        private readonly int memberId;

        public HistoryForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
           dgvHistoryFormWeekly.DataSource=onur.WeeklyHistoryLoader(memberId);
        }

       

        private void dtpHistoryFormMonthly_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpHistoryFormMonthly.Value;
            int month =date.Month;
            dgvHistoryFormMonthly.DataSource = onur.MonthlyHistoryLoader(memberId, month);
        }
    }
}
