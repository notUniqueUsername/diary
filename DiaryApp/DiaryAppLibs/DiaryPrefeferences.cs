using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс хранящий настройки приложения
    /// </summary>
    public class DiaryPrefeferences
    {
        private string _audioPath;
        [JsonProperty]
        public string AudioPath
        {
            get
            {
                return _audioPath;
            }
            private set
            {
                if (File.Exists(value))
                {
                    _audioPath = value;
                }
                else
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Файл не существует");
                    }
                }
            }
        }
        [JsonConstructor]
        public DiaryPrefeferences(string path)
        {
            AudioPath = path;
        }
    }
}
