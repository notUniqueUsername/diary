using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Newtonsoft.Json;
using DiaryAppLibs;

namespace DiaryApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            TimerForRemind.Interval = 1000;
            _diaryPreferences = SaveLoad.LoadPrefs();
            sp = new DiarySoundPlayer(_diaryPreferences.AudioPath);
            _diaryTaskList = SaveLoad.LoadFromFile();
            _displayedDiaryTaskList = _diaryTaskList;
            UpdateMainList();
            ChangeColorAndFontColor(_diaryPreferences);
            if (_diaryTaskList.TaskList.Count == 0)
            {
                Hello();   
            }
        }
        private DiaryPreferences _diaryPreferences;
        private DiarySoundPlayer sp;
        private DiaryTaskList _diaryTaskList;
        private DiaryTaskList _displayedDiaryTaskList;
        private DiaryTaskList _displayedFindDiaryTaskList;

        private void Hello()
        {
            MessageBox.Show(
                "Если вы видите это сообщение значит время напомнить что прикрепленные к заметкам файлы," +
                " а также звуковой файл выбранный для звукового оповещения нельзя перемещать или удалять из папки приложения"
                , "Произошел первый запуск или ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Удалаяет из осовного списка и проверяет надо ли удалять прикрепленный файл.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveDiaryTask(int index)
        {
            int needDeleteFile = 0;
            if (_diaryTaskList.TaskList[index].FileName != "")
            {
                foreach (var Task in _diaryTaskList.TaskList)
                {
                    if (Task.FileName == _diaryTaskList.TaskList[index].FileName)
                    {
                        needDeleteFile++;
                    }
                }
            }


            if (needDeleteFile == 1)
            {
                File.Delete(_diaryTaskList.TaskList[index].FileName);
            }
            _diaryTaskList.TaskList.RemoveAt(index);
        }

        /// <summary>
        /// Изменение цвета шрифта и фона.
        /// </summary>
        /// <param name="diaryPreferences"></param>
        private void ChangeColorAndFontColor(DiaryPreferences diaryPreferences)
        {
            this.BackColor = diaryPreferences.Color;
            this.ForeColor = diaryPreferences.FontColor;
            DiaryMainMenuStrip.BackColor = diaryPreferences.Color;
            DiaryMainMenuStrip.ForeColor = diaryPreferences.FontColor;
            FindListBox.BackColor = diaryPreferences.Color;
            FindListBox.ForeColor = diaryPreferences.FontColor;
            TaskListBox.BackColor = diaryPreferences.Color;
            TaskListBox.ForeColor = diaryPreferences.FontColor;
        }
        /// <summary>
        /// Обновляет основной лист
        /// </summary>
        private void UpdateMainList()
        {
            var list = new List<string>();
            _displayedDiaryTaskList.TaskList.Sort((x1, x2) => x1.TaskDate.CompareTo(x2.TaskDate));
            if (_displayedDiaryTaskList.TaskList.Count != 0)
            {
                foreach (var item in _displayedDiaryTaskList.TaskList)
                {
                    list.Add(item.Name);
                }
            }

            TaskListBox.DataSource = list;
        }

        /// <summary>
        /// Обновялет лист с результатми поиска.
        /// </summary>
        private void UpdateFindList()
        {
            var list = new List<string>();
            foreach (var item in _displayedFindDiaryTaskList.TaskList)
            {
                list.Add(item.Name);
            }
            FindListBox.DataSource = list;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm(_diaryPreferences);
            if (addTaskForm.ShowDialog()== DialogResult.OK)
            {
                _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                _displayedDiaryTaskList = _diaryTaskList;
                UpdateMainList();
            }
            
        }
        /// <summary>
        /// Обработка дабл клика на основном листе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskListBox_MouseUp(object sender, MouseEventArgs e)
        {
            int n = TaskListBox.IndexFromPoint(e.Location);
            if (n != ListBox.NoMatches)
            {
                TaskListBox.SelectedIndex = n;
                var addTaskForm = new AddTaskForm(_diaryPreferences);
                addTaskForm.DiaryTask = _displayedDiaryTaskList.TaskList[n];
                var changedTask = _displayedDiaryTaskList.TaskList[n];
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _diaryTaskList.TaskList.FindIndex(x => CompareDate(x.TaskDate, changedTask.TaskDate, true) &&
                    x.Name == changedTask.Name);
                    if (_diaryTaskList.TaskList == _displayedDiaryTaskList.TaskList)
                    {
                        RemoveDiaryTask(index);
                        //_diaryTaskList.TaskList.RemoveAt(index);
                        _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                        _displayedDiaryTaskList = _diaryTaskList;
                    }
                    else
                    {
                        RemoveDiaryTask(index);
                        //_diaryTaskList.TaskList.RemoveAt(index);
                        _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                        _displayedDiaryTaskList.TaskList.RemoveAt(n);
                        _displayedDiaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    }
                    UpdateMainList();
                }
            }
        }
        /// <summary>
        /// Обработка закрытия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLoad.SaveToFile(_diaryTaskList);
            SaveLoad.SavePrefs(_diaryPreferences);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                var closeForm = new CloseForm(_diaryPreferences);
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
        /// <summary>
        /// Сравнение дат
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="dateTime1"></param>
        /// <param name="withHourAndMinute"></param>
        /// <returns></returns>
        private bool CompareDate(DateTime dateTime, DateTime dateTime1, bool withHourAndMinute)
        {
            if (withHourAndMinute)
            {
                var minuteInDateTime = new DateTime(dateTime.Ticks - dateTime.Ticks % TimeSpan.TicksPerSecond);
                var minuteInDateTime1 = new DateTime(dateTime1.Ticks - dateTime1.Ticks % TimeSpan.TicksPerSecond);
                //return minuteInDateTime1 == minuteInDateTime;
                return dateTime.Day == dateTime1.Day && dateTime.Year == dateTime1.Year &&
                dateTime.Month == dateTime1.Month && dateTime.Hour == dateTime1.Hour &&
                dateTime.Minute == dateTime1.Minute;
            }
            else
            {
                var dayInDateTime = new DateTime(dateTime.Ticks - dateTime.Ticks % TimeSpan.TicksPerHour);
                var dayInDateTime1 = new DateTime(dateTime1.Ticks - dateTime1.Ticks % TimeSpan.TicksPerHour);
                //return dayInDateTime1 == dayInDateTime;
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
                RemoveDiaryTask(index);
                //_diaryTaskList.TaskList.RemoveAt(index);
                //_displayedDiaryTaskList = _diaryTaskList;
                if (_displayedDiaryTaskList.TaskList != _diaryTaskList.TaskList)
                {
                    _displayedDiaryTaskList.TaskList.RemoveAt(TaskListBox.SelectedIndex);
                }

            }
            catch (ArgumentOutOfRangeException)
            {
            }
            UpdateMainList();
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
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
            var aboutForm = new Aboutform(_diaryPreferences);
            aboutForm.ShowDialog();
        }

        private void PrefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prefForm = new PrefForm(_diaryPreferences.AudioPath,_diaryPreferences.FontColor,_diaryPreferences.Color);
            if (prefForm.ShowDialog() == DialogResult.OK)
            {
                _diaryPreferences = prefForm.DiaryPreferences;
                sp = new DiarySoundPlayer(_diaryPreferences.AudioPath);
                ChangeColorAndFontColor(_diaryPreferences);
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Trim().Length != 0)
            {
                _displayedFindDiaryTaskList = new DiaryTaskList();
                foreach (var item in _diaryTaskList.TaskList)
                {
                    if (item.Name.Contains(FindTextBox.Text.Trim()))
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
                var addTaskForm = new AddTaskForm(_diaryPreferences);
                addTaskForm.DiaryTask = _displayedFindDiaryTaskList.TaskList[n];
                var changedTask = _displayedFindDiaryTaskList.TaskList[n];
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _diaryTaskList.TaskList.FindIndex(x => CompareDate(x.TaskDate, changedTask.TaskDate, true) &&
                        x.Name == changedTask.Name);
                    RemoveDiaryTask(index);
                    //_diaryTaskList.TaskList.RemoveAt(index);
                    _diaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    _displayedFindDiaryTaskList.TaskList.RemoveAt(n);
                    _displayedFindDiaryTaskList.TaskList.Add(addTaskForm.DiaryTask);
                    Find_Click(sender,  e);
                    UpdateFindList();
                    _displayedDiaryTaskList = _diaryTaskList;
                    UpdateMainList();
                }
            }
        }

        private void OpenNotify_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool ring = false;
            DiaryTask task = null;
            for (int i = 0; i <= _diaryTaskList.TaskList.Count -1; i++)
            {
                if (_diaryTaskList.TaskList[i].Remind)
                {
                    if (CompareDate(_diaryTaskList.TaskList[i].ReminderDate, DateTime.Now, true))
                    {
                        try
                        {
                            ring = true;
                            _diaryTaskList.TaskList[i] = new DiaryTask(_diaryTaskList.TaskList[i].Name, _diaryTaskList.TaskList[i].TaskDate,
                                !_diaryTaskList.TaskList[i].Remind, _diaryTaskList.TaskList[i].FileName, _diaryTaskList.TaskList[i].ReminderDate.ToString());
                            task = _diaryTaskList.TaskList[i];
                        }
                        catch (ArgumentException exception)
                        {
                            MessageBox.Show(exception.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                }
            }
            if (ring)
            {
                sp.Ring();
                var dialogresult = MessageBox.Show(task.Name, "Выключить", MessageBoxButtons.OK);
                if (dialogresult == DialogResult.OK)
                {
                    sp.Stop();
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void FindTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FindTextBox.TextLength >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void FindTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find_Click(sender, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
