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
            //_diaryTaskList = new DiaryTaskList();
            _diaryTaskList = SaveLoad.LoadFromFile();
            _displayedDiaryTaskList = _diaryTaskList;
            UpdateList();
        }
        private DiarySoundPlayer sp = new DiarySoundPlayer(@"C:\Users\Valeriy\Desktop\-click-nice_1.mp3");
        private DiaryTaskList _diaryTaskList;
        private DiaryTaskList _displayedDiaryTaskList;

        private void UpdateList()
        {
            var list = new List<string>();
            foreach (var item in _displayedDiaryTaskList.TaskList)
            {
                list.Add(item.Name);
            }
            TaskListBox.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            if (addTaskForm.ShowDialog()== DialogResult.OK)
            {
                _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                _displayedDiaryTaskList = _diaryTaskList;
                UpdateList();
            }
            
        }

        private void TaskListBox_MouseUp(object sender, MouseEventArgs e)
        {
            int n = TaskListBox.IndexFromPoint(e.Location);
            if (n != ListBox.NoMatches)
            {
                TaskListBox.SelectedIndex = n;
                var addTaskForm = new AddTaskForm();
                addTaskForm.DiaryTask = _diaryTaskList.TaskList[n];
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    _diaryTaskList.TaskList.RemoveAt(n);
                    _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    _displayedDiaryTaskList = _diaryTaskList;
                    UpdateList();
                }
            }
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLoad.SaveToFile(_diaryTaskList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _diaryTaskList.TaskList.RemoveAt(TaskListBox.SelectedIndex);
            _displayedDiaryTaskList = _diaryTaskList;
            UpdateList();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.Day == e.End.Day)
            {
                _displayedDiaryTaskList = new DiaryTaskList();
                foreach (var task in _diaryTaskList.TaskList)
                {
                    if (task.TaskDate.Day == e.Start.Day && task.TaskDate.Year == e.Start.Year && task.TaskDate.Month == e.Start.Month)
                    {
                        _displayedDiaryTaskList.TaskList.Add(task);
                        
                    }
                }
                UpdateList();
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
                    UpdateList();
                }

            }

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp.ring();
        }

        private void PrefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
    }
}
