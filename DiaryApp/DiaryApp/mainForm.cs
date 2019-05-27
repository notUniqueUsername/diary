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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            //_diaryTaskList = new DiaryTaskList();
            _diaryTaskList = SaveLoad.LoadFromFile();
            _displayedDiaryTaskList = _diaryTaskList;
            UpdateMainList();
        }
        private DiarySoundPlayer sp = new DiarySoundPlayer(@"C:\Users\Valeriy\Desktop\-click-nice_1.mp3");
        private DiaryTaskList _diaryTaskList;
        private DiaryTaskList _displayedDiaryTaskList;
        private DiaryTaskList _displayedFindDiaryTaskList;

        private void UpdateMainList()
        {
            var list = new List<string>();
            foreach (var item in _displayedDiaryTaskList.TaskList)
            {
                list.Add(item.Name);
            }
            TaskListBox.DataSource = list;
        }

        private void UpdateFindList()
        {
            var list = new List<string>();
            foreach (var item in _displayedFindDiaryTaskList.TaskList)
            {
                list.Add(item.Name);
            }
            FindListBox.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            if (addTaskForm.ShowDialog()== DialogResult.OK)
            {
                _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                _displayedDiaryTaskList = _diaryTaskList;
                UpdateMainList();
            }
            
        }

        private void TaskListBox_MouseUp(object sender, MouseEventArgs e)
        {
            int n = TaskListBox.IndexFromPoint(e.Location);
            if (n != ListBox.NoMatches)
            {
                TaskListBox.SelectedIndex = n;
                var addTaskForm = new AddTaskForm();
                addTaskForm.DiaryTask = _displayedDiaryTaskList.TaskList[n];
                var changedTask = _displayedDiaryTaskList.TaskList[n];
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _diaryTaskList.TaskList.FindIndex(x => CompareDate(x.TaskDate, changedTask.TaskDate, true) &&
                    x.Name == changedTask.Name);
                    _diaryTaskList.TaskList.RemoveAt(index);
                    _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    _displayedDiaryTaskList.TaskList.RemoveAt(n);
                    _displayedDiaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    UpdateMainList();
                }
            }
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLoad.SaveToFile(_diaryTaskList);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                var closeForm = new CloseForm();
                if (closeForm.ShowDialog() == DialogResult.OK)
                {
                    if (closeForm.MinimizeORExit)
                    {
                        this.Hide();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private bool CompareDate(DateTime dateTime, DateTime dateTime1, bool withHourAndMinute)
        {
            if (withHourAndMinute)
            {
                return dateTime.Day == dateTime1.Day && dateTime.Year == dateTime1.Year &&
                dateTime.Month == dateTime1.Month && dateTime.Hour == dateTime1.Hour &&
                dateTime.Minute == dateTime1.Minute;
            }
            else
            {
                return dateTime.Day == dateTime1.Day && dateTime.Year == dateTime1.Year &&
                dateTime.Month == dateTime1.Month;
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var index = _diaryTaskList.TaskList.FindIndex(x => CompareDate(x.TaskDate, _displayedDiaryTaskList.TaskList[TaskListBox.SelectedIndex].TaskDate, true) &&
                    x.Name == _displayedDiaryTaskList.TaskList[TaskListBox.SelectedIndex].Name);
                _diaryTaskList.TaskList.RemoveAt(index);
                _displayedDiaryTaskList.TaskList.RemoveAt(TaskListBox.SelectedIndex);
                //_displayedDiaryTaskList = _diaryTaskList;
                UpdateMainList();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.Day == e.End.Day)
            {
                _displayedDiaryTaskList = new DiaryTaskList();
                foreach (var task in _diaryTaskList.TaskList)
                {
                    if (CompareDate(task.TaskDate, e.Start, false))
                    {
                        _displayedDiaryTaskList.TaskList.Add(task);
                    }
                }
                UpdateMainList();
            }
            else
            {
                _displayedDiaryTaskList = new DiaryTaskList();
                foreach (var task in _diaryTaskList.TaskList)
                {
                    if ((e.End.Day >= task.TaskDate.Day && task.TaskDate.Day >= e.Start.Day) &&
                        (e.End.Year >= task.TaskDate.Year && task.TaskDate.Year >= e.Start.Year) && 
                        (e.End.Month >= task.TaskDate.Month && task.TaskDate.Month >= e.Start.Month))
                    {
                        _displayedDiaryTaskList.TaskList.Add(task);
                    }
                    UpdateMainList();
                }

            }

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp.Ring();
        }

        private void PrefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length != 0)
            {
                _displayedFindDiaryTaskList = new DiaryTaskList();
                foreach (var item in _diaryTaskList.TaskList)
                {
                    if (item.Name.Contains(textBox1.Text.Trim()))
                    {
                        _displayedFindDiaryTaskList.TaskList.Add(item);
                    }
                }
                UpdateFindList();
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            _displayedDiaryTaskList = _diaryTaskList;
            UpdateMainList();
        }

        private void FindListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = FindListBox.IndexFromPoint(e.Location);
            if (n != ListBox.NoMatches)
            {
                FindListBox.SelectedIndex = n;
                var addTaskForm = new AddTaskForm();
                addTaskForm.DiaryTask = _displayedFindDiaryTaskList.TaskList[n];
                var changedTask = _displayedFindDiaryTaskList.TaskList[n];
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _diaryTaskList.TaskList.FindIndex(x => CompareDate(x.TaskDate, changedTask.TaskDate, true) &&
                        x.Name == changedTask.Name);
                    _diaryTaskList.TaskList.RemoveAt(index);
                    _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    _displayedFindDiaryTaskList.TaskList.RemoveAt(n);
                    _displayedFindDiaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    button3_Click(sender,  e);
                    UpdateFindList();
                    _displayedDiaryTaskList = _diaryTaskList;
                    UpdateMainList();
                }
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
