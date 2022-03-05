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
    public partial class BMICalcForm : Form
    {
        private readonly int memberId;
        Alper alper;
        public BMICalcForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }
    }
}
