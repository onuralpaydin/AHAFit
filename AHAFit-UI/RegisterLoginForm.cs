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
    public partial class RegisterLoginForm : Form
    {
        AutomaticData AutomaticData = new AutomaticData();
        MemberData MemberData = new MemberData();

        public RegisterLoginForm()
        {
            AutomaticData.MealAndGoalDataLoad();
            AutomaticData.AutoAdminMember();
            AutomaticData.AddWaterToFoods();
            Huseyin.AutoMembers();
            Huseyin.AutoFoods();
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(MemberData.MemberLoginControl(txtEmail.Text,txtPassword.Text))
            {
                MessageBox.Show("Giriş Başarılı");
                MainForm newHomeForm = new MainForm(MemberData.MemberIdFounder(txtEmail.Text));
                newHomeForm.Show();
                this.Hide();
            }
                
            else
                MessageBox.Show("Giriş Başarısız");
        }

        private void RegisterLoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@admin.com";
            txtPassword.Text = "asdfghH1.";
        }
    }
}
