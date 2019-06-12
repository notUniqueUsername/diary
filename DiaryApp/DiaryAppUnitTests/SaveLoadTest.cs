using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using NUnit.Framework;
using DiaryAppLibs;

namespace DiaryAppUnitTests
{
    public class SaveLoadTest
    {
        private List<DiaryTask> _diaryTasks = new List<DiaryTask>();
        private DiaryTask _diaryTask;
        private DiaryPreferences _diaryPreferences;
        private DiaryTaskList _diaryTaskList;
        [SetUp]
        public void Setup()
        {
            _diaryPreferences = new DiaryPreferences(@"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests" + @"\-click-nice_1.mp3"
                , Color.Black
                , Color.LightSalmon);
            string name = "";
            for (int i = 0; i < 3; i++)
            {
                name = i.ToString();
                _diaryTask = new DiaryTask(name,DateTime.Now,false);
                _diaryTasks.Add(_diaryTask);
            }
            _diaryTaskList =new DiaryTaskList(_diaryTasks);
            File.CreateText(@"D:\games\DiaryTest.diary");
        }

        [Test]
        [TestCase(
            TestName = "Тест сохранения в файл")]
        public void SaveDiaryTaskListTest()
        {
            string path = @"D:\games\DiaryTest.diary";
            SaveLoad.SaveToFile(_diaryTaskList, path);
            var testedListFromFile =  SaveLoad.LoadFromFile(path);
            for (int i = 0; i < testedListFromFile.TaskList.Count; i++)
            {
                Assert.AreEqual(_diaryTaskList.TaskList[i], testedListFromFile.TaskList[i]);
            }
            
        }
    }
}