using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class Aboutform : Form
    {
        public Aboutform()
        {
            InitializeComponent();
        }

        private void EmailLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:{0}",EmailLinkLabel.Text);
        }
    }
}
