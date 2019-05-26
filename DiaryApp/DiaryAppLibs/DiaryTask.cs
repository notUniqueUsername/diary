using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiaryAppLibs
{
    public class DiaryTask
    {
        private bool _file;
        private DateTime _reminderDate;
        private DateTime _taskDate;
        private string _name;
        private string _filename;
        /*public string Audio
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
        }*/

        public bool Remind { get; private set; }

        public string FileName
        {
            private set
            {
                if (value != "")
                {
                    if (!File.Exists(value))
                    {
                        throw new ArgumentException("Фаил не сущесвует");
                    }
                    _filename = value;
                }
                else
                {
                    _filename = "";
                }
                
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
        [JsonProperty]
        public DateTime ReminderDate
        {
            private set
            {
                if (_taskDate.Year < value.Year && _taskDate.Month < value.Month && _taskDate.Hour < value.Hour && _taskDate.Day < value.Day && _taskDate.Minute < value.Minute )
                {
                    throw new ArgumentException("Дата напоминания не может быть позже даты окончания задачи");
                }
                if (value < new DateTime(1901, 1, 1))
                {
                    if (value.ToString() != "01.01.0001 0:00:00")
                    {
                        throw new ArgumentException("дата напоминания не может быть раньше 1900 года");
                    }
                    
                }
                    
                if (value.Year < DateTime.Now.Year && value.Month < DateTime.Now.Month && value.Day < DateTime.Now.Day && value.Hour < DateTime.Now.Hour && value.Minute < DateTime.Now.Minute)
                {
                    throw new ArgumentException("дата напоминания не может быть раньше чем сейчас");
                }
                    
                _reminderDate = value;
            }
            get
            {
                return _reminderDate;
            }
        }

        [JsonConstructor]
        public DiaryTask(string name, DateTime taskDate, bool remind, string filename = "", string remindDate = "01.01.0001 0:00:00")
        {
            Name = name;
            FileName = filename;
            TaskDate = taskDate;
            Remind = remind;
            if (remind)
            {
                DateTime reminddate;
                DateTime.TryParse(remindDate, out reminddate);
                ReminderDate = reminddate;
            }
            else
            {
                ReminderDate = taskDate;
            }
            CheckFile();
        }

        private void CheckFile()
        {
            if (FileName == "")
            {
                _file = false;
            }
        }
    }
}
