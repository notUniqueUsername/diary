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
                    NameTextBox.Text = value.Name;
                    TaskTimePicker.Value = value.TaskDate;
                    if (value.Remind)
                    {
                        RemindCheckBox.Checked = value.Remind;
                        RemindTimePicker.Value = value.ReminderDate;
                    }
                    LockUnlock();
                    RedactPictureBox.Visible = true;
                }
                _diaryTask = value;
            }
        }

        public AddTaskForm(DiaryPreferences diaryPreferences)
        {
            InitializeComponent();
            TaskTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.CustomFormat = "dd.MM.yyyy - HH:mm";
            RemindTimePicker.Enabled = false;
            RedactPictureBox.Visible = false;
            ChangeColor(diaryPreferences);
        }

        private void ChangeColor(DiaryPreferences diaryPreferences)
        {
            this.BackColor = diaryPreferences.Color;
            this.ForeColor = diaryPreferences.FontColor;
            RemindCheckBox.BackColor = diaryPreferences.Color;
            RemindCheckBox.ForeColor = diaryPreferences.FontColor;
            NameTextBox.ForeColor = diaryPreferences.FontColor;
            NameTextBox.BackColor = Color.DarkTurquoise;
        }

        private void ChangeFileLabel(string path)
        {
            _pathTOFile = path;
            var lastIndex = path.LastIndexOf(@"\");
            FileNameLabel.Text = path.Substring(lastIndex + 1);
            FileNameLabel.Click += FileLabel_Click;
            FileNameLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(204)));
            FileNameLabel.Cursor = Cursors.Hand;
        }

        private void LockUnlock()
        {

            if (NameTextBox.Enabled)
            {
                NameTextBox.Enabled = false;
                AddfileButton.Enabled = false;
                RemindCheckBox.Enabled = false;
                TaskTimePicker.Enabled = false;
                RemindTimePicker.Enabled = false;
            }
            else
            {
                NameTextBox.Enabled = true;
                AddfileButton.Enabled = true;
                RemindCheckBox.Enabled = true;
                TaskTimePicker.Enabled = true;
                if (RemindCheckBox.Checked)
                {
                    RemindTimePicker.Enabled = true;
                }
                
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (RemindCheckBox.Checked)
            {
                RemindTimePicker.Enabled = true;
            }
            else if (!RemindCheckBox.Checked)
            {
                RemindTimePicker.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openfileDialog1.ShowDialog() == DialogResult.OK)
            {
                ChangeFileLabel(openfileDialog1.FileName);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (RemindCheckBox.Checked)
                {
                    _diaryTask = new DiaryTask(NameTextBox.Text, TaskTimePicker.Value, RemindCheckBox.Checked, openfileDialog1.FileName, RemindTimePicker.Value.ToString());
                }
                if (!RemindCheckBox.Checked)
                {
                    _diaryTask = new DiaryTask(NameTextBox.Text, TaskTimePicker.Value, RemindCheckBox.Checked, openfileDialog1.FileName);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FileLabel_Click(object sender, EventArgs e)
        {
            Process.Start(_pathTOFile);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            LockUnlock();
            RedactPictureBox.Visible = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength >= 50)
            {
                var tooltip = new ToolTip();
                tooltip.SetToolTip(this.NameTextBox, "Максимальная длина 50 символов");
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NameTextBox.TextLength >= 50 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
