using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DiaryAppLibs;
using NUnit;
using NUnit.Framework;

namespace DiaryUnitTests
{
    public class SaveLoadTest
    {
        private List<DiaryTask> _diaryTasks = new List<DiaryTask>();
        private DiaryTask _diaryTask;
        private DiaryTaskList _diaryTaskList;
        private DiaryPreferences _diaryPreferences;
        [SetUp]
        public void Setup()
        {
            _diaryPreferences = new DiaryPreferences(@"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests" + @"\Ring.mp3"
                , Color.Green
                , Color.LightSalmon);
            string name = "";
            for (int i = 0; i < 3; i++)
            {
                name = i.ToString();
                _diaryTask = new DiaryTask(name, DateTime.Now, false);
                _diaryTasks.Add(_diaryTask);
            }
            _diaryTaskList = new DiaryTaskList(_diaryTasks);
            //File.CreateText(@"D:\games\DiaryTest.diary");
        }

        [Test]
        [TestCase(
            TestName = "Тест сериализации списка задач")]
        public void SaveDiaryTaskListTest()
        {
            string path = @"D:\games\DiaryTest.diary";
            SaveLoad.SaveToFile(_diaryTaskList, path);
            var testedListFromFile = SaveLoad.LoadFromFile(path);
            for (int i = 0; i < testedListFromFile.TaskList.Count; i++)
            {
                Assert.AreEqual(_diaryTaskList.TaskList[i].Name, testedListFromFile.TaskList[i].Name);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест десериализации списка задач")]
        public void LoadDiaryTaskListTest()
        {
            string path = @"D:\games\DiaryTest.diary";
            SaveLoad.SaveToFile(_diaryTaskList, path);
            var testedListFromFile = SaveLoad.LoadFromFile(path);
            for (int i = 0; i < testedListFromFile.TaskList.Count; i++)
            {
                Assert.AreEqual(_diaryTaskList.TaskList[i].Name, testedListFromFile.TaskList[i].Name);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест десериализации списка задач если файл не найден")]
        public void LoadWithoutFileDiaryTaskListTest()
        {
            string path = @"D:\games\DiaryTest.diary";
            SaveLoad.SaveToFile(_diaryTaskList, path);
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var testedListFromFile = SaveLoad.LoadFromFile(path);
            Assert.AreEqual(0,testedListFromFile.TaskList.Count);
        }

        [Test]
        [TestCase(
            TestName = "Тест десериализации настроек если файл не найден")]
        public void LoadWithoutFileDiaryPrefTest()
        {
            string path = @"D:\games\DiaryPrefTest.diarypref";
            SaveLoad.SavePrefs(_diaryPreferences, path);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            var ppath = Environment.CurrentDirectory.ToString();
            //File.Copy(@"C:\Users\Valeriy\Desktop\Ring.mp3", ppath+ @"\Ring.mp3");
            var testedPrefs = SaveLoad.LoadPrefs(path);
            Assert.AreEqual(Color.Black, testedPrefs.FontColor);
        }

        [Test]
        [TestCase(
            TestName = "Тест десериализации настроек")]
        public void LoadFileDiaryPrefTest()
        {
            string path = @"D:\games\DiaryPrefTest.diarypref";
            SaveLoad.SavePrefs(_diaryPreferences, path);
            var testedPrefs = SaveLoad.LoadPrefs(path);
            Assert.AreEqual(_diaryPreferences.Color, testedPrefs.Color);
            Assert.AreEqual(_diaryPreferences.FontColor, testedPrefs.FontColor);
            Assert.AreEqual(_diaryPreferences.AudioPath, testedPrefs.AudioPath);
        }

        [Test]
        [TestCase(
            TestName = "Тест сериализации настроек")]
        public void SaveFileDiaryPrefTest()
        {
            string path = @"D:\games\DiaryPrefTest.diarypref";
            SaveLoad.SavePrefs(_diaryPreferences, path);
            var testedPrefs = SaveLoad.LoadPrefs(path);
            Assert.AreEqual(_diaryPreferences.Color, testedPrefs.Color);
            Assert.AreEqual(_diaryPreferences.FontColor, testedPrefs.FontColor);
            Assert.AreEqual(_diaryPreferences.AudioPath, testedPrefs.AudioPath);
        }
    }
}
