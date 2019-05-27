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
    public partial class AddTaskForm : Form
    {
        private OpenFileDialog openfileDialog1 = new OpenFileDialog();
        private DiaryTask _diaryTask;
        private string _pathTOFile;
        public DiaryTask DiaryTask
        {
            get
            {
                return _diaryTask;
            }
            set
            {
                if (value != null)
                {
                    
                    if (value.FileName != "")
                    {
                        ChangeFileLabel(value.FileName);
                    }
                    textBox1.Text = value.Name;
                    TaskTimePicker.Value = value.TaskDate;
                    if (value.Remind)
                    {
                        checkBox1.Checked = value.Remind;
                        RemindTimePicker.Value = value.ReminderDate;
                    }
                    LockUnlock();
                    pictureBox1.Visible = true;
                }
                _diaryTask = value;
            }
        }

        public AddTaskForm()
        {
            InitializeComponent();
            TaskTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.Enabled = false;
            pictureBox1.Visible = false;
        }

        private void ChangeFileLabel(string path)
        {
            _pathTOFile = path;
            var lastIndex = path.LastIndexOf(@"\");
            label2.Text = path.Substring(lastIndex + 1);
            label2.Click += FileLabel_Click;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(204)));
            label2.Cursor = Cursors.Hand;
        }

        private void LockUnlock()
        {

            if (textBox1.Enabled)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                checkBox1.Enabled = false;
                TaskTimePicker.Enabled = false;
                RemindTimePicker.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
                checkBox1.Enabled = true;
                TaskTimePicker.Enabled = true;
                if (checkBox1.Checked)
                {
                    RemindTimePicker.Enabled = true;
                }
                
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openfileDialog1.ShowDialog() == DialogResult.OK)
            {
                ChangeFileLabel(openfileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _diaryTask = new DiaryTask(textBox1.Text,TaskTimePicker.Value, checkBox1.Checked, openfileDialog1.FileName, RemindTimePicker.Value.ToString());
            }
            if (!checkBox1.Checked)
            {
                _diaryTask = new DiaryTask(textBox1.Text, TaskTimePicker.Value, checkBox1.Checked, openfileDialog1.FileName);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FileLabel_Click(object sender, EventArgs e)
        {
            Process.Start(_pathTOFile);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LockUnlock();
            pictureBox1.Visible = false;
        }
    }
}
