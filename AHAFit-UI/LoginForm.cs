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
    public partial class LoginForm : Form
    {
        AutomaticData AutomaticData = new AutomaticData();
        MemberData MemberData = new MemberData();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;

        public LoginForm()
        {
            AutomaticData.MealAndGoalDataLoad();
            AutomaticData.AutoAdminMember();
            AutomaticData.AddWaterToFoods();
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
            DesignChanges();
        }

        private void DesignChanges()
        {
            pnlTop.BackColor = Color.FromArgb(166, 83, 105);
            flwPnlLeftSide.BackColor = Color.FromArgb(46, 65, 89);
            btnLogin2.BackColor = Color.FromArgb(168, 181, 191);
            btnRegister.BackColor = Color.FromArgb(168, 181, 191);
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlResizeRight_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void pnlResizeRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void pnlResizeRight_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
