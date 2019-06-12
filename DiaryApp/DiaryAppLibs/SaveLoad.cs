using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс для сохранения и загрузки данных необходимы для работы приложения
    /// </summary>
    public static class SaveLoad
    {
        public static void SavePrefs(DiaryPreferences data, string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = Environment.CurrentDirectory.ToString() + @"\Preferences.diarypref";
            }
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static DiaryPreferences LoadPrefs(string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = Environment.CurrentDirectory.ToString() + @"\Preferences.diarypref";
            }
            try
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (DiaryPreferences)serializer.Deserialize(file, typeof(DiaryPreferences));
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                var fontColor = Color.Black;
                var color = Color.LightSalmon;
                var project = new DiaryPreferences(Environment.CurrentDirectory.ToString() + @"\-click-nice_1.mp3",fontColor,color);
                SaveLoad.SavePrefs(project, filePath);
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (DiaryPreferences)serializer.Deserialize(file, typeof(DiaryPreferences));
                }
            }
        }

        /// <summary>
        /// Запись в фаил
        /// </summary>
        /// <param name="data">
        /// Список записываемых задач
        /// </param>
        public static void SaveToFile(DiaryTaskList data, string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = Environment.CurrentDirectory.ToString() + @"\Diary.diary";
            }
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        /// Чтение из фаила
        /// </summary>
        /// <returns>
        /// Список задач
        /// </returns>
        public static DiaryTaskList LoadFromFile(string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Diary.diary";
            }
            try
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (DiaryTaskList)serializer.Deserialize(file, typeof(DiaryTaskList));
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                var project = new DiaryTaskList();
                SaveLoad.SaveToFile(project, filePath);
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (DiaryTaskList)serializer.Deserialize(file, typeof(DiaryTaskList));
                }
            }
        }
    }
}
