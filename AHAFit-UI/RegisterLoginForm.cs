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
        public RegisterLoginForm()
        {
            Huseyin.MealAndGoalDataLoad();
            Huseyin.AutoAdminMember();
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(Huseyin.MemberLoginControl(txtEmail.Text,txtPassword.Text))
            {
                MessageBox.Show("Giriş Başarılı");
                HomeForm newHomeForm = new HomeForm(Huseyin.MemberIdFounder(txtEmail.Text));
                newHomeForm.Show();
                this.Hide();
            }
                
            else
                MessageBox.Show("Giriş Başarısız");
        }

        private void RegisterLoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@admin.com";
            txtPassword.Text = "admin";
        }
    }
}
