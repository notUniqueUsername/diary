using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс содержащий логику и структуру списка задач
    /// </summary>
    public class DiaryTaskList
    {
        /// <summary>
        /// Лист содержащий список всех задач
        /// </summary>
        public List<DiaryTask> TaskList { private set; get; }

        /// <summary>
        /// Конструктор класса если список есть
        /// </summary>
        /// <param name="tasklist">список</param>
        public DiaryTaskList(List<DiaryTask> tasklist)
        {
            TaskList = tasklist;
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public DiaryTaskList()
        {
            TaskList = new List<DiaryTask>();
        }
    }
}
