using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
            TaskTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RemindTimePicker.Enabled = true;
            }
            else if (!checkBox1.Checked)
            {
                RemindTimePicker.Enabled = false;
            }
        }
    }
}
