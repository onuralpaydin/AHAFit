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
    public partial class AddDailyFoodForm : Form
    {
        private readonly int memberId;

        public AddDailyFoodForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void AddDailyFoodForm_Load(object sender, EventArgs e)
        {

        }
    }
}
