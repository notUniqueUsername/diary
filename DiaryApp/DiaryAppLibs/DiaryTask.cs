﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс содержащий логику и структуру задачи
    /// </summary>
    public class DiaryTask
    {
        /// <summary>
        /// Поле содержащее данные о прикреплении файла
        /// </summary>
        private bool _file;
        /// <summary>
        /// Дата напомнинаия
        /// </summary>
        private DateTime _reminderDate;
        /// <summary>
        /// Дата задачи
        /// </summary>
        private DateTime _taskDate;
        /// <summary>
        /// Название задачи
        /// </summary>
        private string _name;
        /// <summary>
        /// Полное имя файла
        /// </summary>
        private string _filename;

        /// <summary>
        /// Свойство управляет напоминанием
        /// </summary>
        public bool Remind { get; private set; }

        /// <summary>
        /// Свойство для доступа к имени файла
        /// </summary>
        public string FileName
        {
            private set
            {

                if (value != "")
                {
                    if (!File.Exists(value))
                    {
                        throw new ArgumentException("Фаил не существует");
                    }
                    var lastIndex = value.LastIndexOf(@"\");
                    var filename = value.Substring(lastIndex + 1);
                    var filepath = Environment.CurrentDirectory.ToString() + @"\" + filename;
                    if (!File.Exists(filepath))
                    {
                        File.Copy(value, filepath);
                    }
                    //создание ярлыка файла
                    /*Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
                    dynamic shell = Activator.CreateInstance(t);
                    try
                    {
                        var lnk = shell.CreateShortcut("sc.lnk");
                        try
                        {
                            
                            lnk.TargetPath = value;
                            lnk.IconLocation = "shell32.dll, 1";
                            lnk.Save();
                        }
                        finally
                        {
                            Marshal.FinalReleaseComObject(lnk);
                        }
                    }
                    finally
                    {
                        Marshal.FinalReleaseComObject(shell);
                    }*/
                    _filename = filepath;
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

        /// <summary>
        /// Свойство для доступа к названию задачи
        /// </summary>
        public string Name
        {
            private set
            {
                if (value.Trim().Length > 50)
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

        /// <summary>
        /// Свойство для доступа к дате задачи
        /// </summary>
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

        /// <summary>
        /// Свойство для доступа к дате напоминания
        /// </summary>
        [JsonProperty]
        public DateTime ReminderDate
        {
            private set
            {
                var minuteInValue = new DateTime(value.Ticks -value.Ticks % TimeSpan.TicksPerSecond);
                var minuteInTaskDate = new DateTime(_taskDate.Ticks - _taskDate.Ticks % TimeSpan.TicksPerSecond);
                if (minuteInTaskDate < minuteInValue)
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


                    
                _reminderDate = value;
            }
            get
            {
                return _reminderDate;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <param name="taskDate">дата задачи</param>
        /// <param name="remind">необходимо ли напоминать</param>
        /// <param name="filename">полный путь до файла</param>
        /// <param name="reminderDate">дата напоминания</param>
        [JsonConstructor]
        public DiaryTask(string name, DateTime taskDate, bool remind, string filename = "", string reminderDate = "01.01.0001 0:00:00")
        {
            Name = name;
            FileName = filename;
            TaskDate = taskDate;
            Remind = remind;
            if (remind)
            {
                DateTime reminddate;
                var c = DateTime.TryParse(reminderDate, out reminddate);
                ReminderDate = reminddate;
            }
            else
            {
                ReminderDate = taskDate;
            }
            CheckFile();
        }

        /// <summary>
        /// Проверка прикрепления файла
        /// </summary>
        private void CheckFile()
        {
            if (FileName == "")
            {
                _file = false;
            }
        }
    }
}
