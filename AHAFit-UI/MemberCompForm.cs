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
    public partial class MemberCompForm : Form
    {
        MemberData MemberData = new MemberData();
        private readonly int memberId;

        public MemberCompForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var champUser = MemberData.CalorieChampUserFinder(0);
            lblUserName.Text = champUser.First().Key + " " + String.Format("{0:n}", champUser.First().Value) + " Cal"; 
            dgvCompare.DataSource = MemberData.MemberCompare(0);
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            var champUser = MemberData.CalorieChampUserFinder(30);
            lblUserName.Text = champUser.First().Key + " " + String.Format("{0:n}", champUser.First().Value) + " Cal";
            dgvCompare.DataSource = MemberData.MemberCompare(30);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            var champUser = MemberData.CalorieChampUserFinder(7);
            lblUserName.Text = champUser.First().Key + " " + String.Format("{0:n}", champUser.First().Value) + " Cal";
            dgvCompare.DataSource = MemberData.MemberCompare(7);
        }
    }
}
