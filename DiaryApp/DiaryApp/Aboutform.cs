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
using DiaryAppLibs;

namespace DiaryApp
{
    public partial class Aboutform : Form
    {
        public Aboutform(DiaryPreferences diaryPreferences)
        {
            InitializeComponent();
            ChangeColor(diaryPreferences);
        }

        private void ChangeColor(DiaryPreferences diaryPreferences)
        {
            this.BackColor = diaryPreferences.Color;
            this.ForeColor = diaryPreferences.FontColor;
            this.TextBox.BackColor = diaryPreferences.Color;
            this.TextBox.ForeColor = diaryPreferences.FontColor;
        }

        private void EmailLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:{0}",EmailLinkLabel.Text);
        }
    }
}
