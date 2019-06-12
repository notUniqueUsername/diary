using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DiaryAppLibs;
using NUnit;
using NUnit.Framework;

namespace DiaryUnitTests
{
    public class DiaryTaskListTest
    {
        private List<DiaryTask> _diaryTasks = new List<DiaryTask>();
        private DiaryTask _diaryTask;

        [SetUp]
        public void Setup()
        {
            string name = "";
            for (int i = 0; i < 3; i++)
            {
                name = i.ToString();
                _diaryTask = new DiaryTask(name, DateTime.Now, false);
                _diaryTasks.Add(_diaryTask);
            }
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест конструктора по умолчанию")]
        public void ConstructorTaskListTest()
        {
            DiaryTaskList diaryTaskList = new DiaryTaskList();
            Assert.AreEqual(0,diaryTaskList.TaskList.Count);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест конструктора с аргументами")]
        public void ConstructorWithArgsTaskListTest()
        {
            DiaryTaskList diaryTaskList = new DiaryTaskList(_diaryTasks);
            for (int i = 0; i < diaryTaskList.TaskList.Count; i++)
            {
                Assert.AreEqual(_diaryTasks[i].Name, diaryTaskList.TaskList[i].Name);
            }
        }
    }
}