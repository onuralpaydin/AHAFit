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
        private readonly int memberId;

        public MemberCompForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }
    }
}
