using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс хранящий настройки приложения
    /// </summary>
    public class DiaryPreferences
    {
        /// <summary>
        /// Цвет шрифта.
        /// </summary>
        [JsonProperty]
        public Color FontColor { get; private set; }
        /// <summary>
        /// Цвет фона.
        /// </summary>
        [JsonProperty]
        public Color Color { get; private set; }
        /// <summary>
        /// Путь к звуку оповещения.
        /// </summary>
        private string _audioPath;
        /// <summary>
        /// Свойство для пути к звуку.
        /// </summary>
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
                    var valueLength = value.Length;
                    if (valueLength > 5)
                    {
                        var extension = value.Substring(valueLength - 3);
                        if (extension == "wav" || extension == "mp3")
                        {
                            _audioPath = value;
                        }
                        else
                        {
                            throw new ArgumentException("Неподдерживаемое расширение файла");
                        }
                    }
                    else
                    {
                        throw  new ArgumentException("Неподдерживаемое расширение файла");
                    }
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
        public DiaryPreferences(string path, Color fontColor, Color color)
        {
            Color = color;
            FontColor = fontColor;
            AudioPath = path;
        }
    }
}
