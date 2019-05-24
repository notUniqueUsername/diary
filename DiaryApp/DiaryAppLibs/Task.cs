using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryAppLibs
{
    public class Task
    {
        private string _audio;
        private DateTime _reminderDate;
        private DateTime _taskDate;
        private string _name;
        private string _filename;

        public string Audio
        {
            private set
            {
                if (!File.Exists(value))
                {
                    throw new ArgumentException("Фаил не сущесвует");
                }
                _audio = value;
            }
            get
            {
                return _audio;
            }
        }

        public string FileName
        {
            private set
            {
                if (!File.Exists(value))
                {
                    throw new ArgumentException("Фаил не сущесвует");
                }
                _filename = value;
            }
            get
            {
                return _filename;
            }
        }

        public string Name
        {
            private set
            {
                if (value.Trim().Length >= 50)
                {
                    throw new ArgumentException("В названии более 50 символов");
                }
                _name = value.Trim();
            }
            get
            {
                return _name;
            }
        }

        public DateTime TaskDate
        {
            private set
            {
                if (value < new DateTime(1901, 1, 1))
                    throw new ArgumentException("дата задачи не может быть раньше 1900 года");

                _taskDate = value;
            }
            get
            {
                return _taskDate;
            }
        }

        public DateTime ReminderDate
        {
            private set
            {
                if (_taskDate <= value)
                {
                    throw new ArgumentException("Дата напоминания не может быть позже даты окончания задачи");
                }
                if (value < new DateTime(1901, 1, 1))
                    throw new ArgumentException("дата напоминания не может быть раньше 1900 года");

                _reminderDate = value;
            }
            get
            {
                return _reminderDate;
            }
        }

        public Task(string audio, string name, string filename, DateTime taskDate, DateTime reminderDate)
        {
            Name = name;
            Audio = audio;
            FileName = filename;
            TaskDate = taskDate;
            ReminderDate = reminderDate;
        }
        public Task(string audio, string name, string filename, DateTime taskDate)
        {
            Name = name;
            Audio = audio;
            FileName = filename;
            TaskDate = taskDate;
        }

    }
}
