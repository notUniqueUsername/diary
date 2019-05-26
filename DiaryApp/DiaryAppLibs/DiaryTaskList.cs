using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryAppLibs
{
    public class DiaryTaskList
    {
        public List<DiaryTask> TaskList { private set; get; }

        public DiaryTaskList(List<DiaryTask> tasklist)
        {
            TaskList = tasklist;
        }

        public DiaryTaskList()
        {
            TaskList = new List<DiaryTask>();
        }
    }
}
