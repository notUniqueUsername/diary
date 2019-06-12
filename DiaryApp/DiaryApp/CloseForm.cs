using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryAppLibs;

namespace DiaryApp
{
    public partial class CloseForm : Form
    {
        public CloseForm(DiaryPreferences diaryPreferences)
        {
            InitializeComponent();
            ChangeColor(diaryPreferences);
        }

        private void ChangeColor(DiaryPreferences diaryPreferences)
        {
            this.BackColor = diaryPreferences.Color;
            this.ForeColor = diaryPreferences.FontColor;
        }

        public bool MinimizeORExit { private set; get; }

        private void button1_Click(object sender, EventArgs e)
        {
            MinimizeORExit = radioButton1.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
