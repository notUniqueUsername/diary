using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DiaryAppLibs;
using NUnit;
using NUnit.Framework;

namespace DiaryUnitTests
{
    public class DiaryTaskTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", true, @"C:\Users\Valeriy\Desktop\390.txt", "2019.12.12 0:00:00",
            TestName = "Позитивный тест конструктора: с напоминанием, с прикрепленным файлом")]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", true, "", "2019.12.12 0:00:00",
            TestName = "Позитивный тест конструктора: с напоминанием, без прикрепленного файла")]
        public void ConstructorWithRemindDiaryTaskTest(string name, string taskDateString, bool remind, string filename, string remindDate)
        {
            DateTime.TryParse(taskDateString, out var taskDate);
            DateTime.TryParse(remindDate, out var remind1Date);
            var test = new DiaryTask(name, taskDate, remind, filename,remindDate);
            Assert.AreEqual(name,test.Name);
            Assert.AreEqual(taskDate, test.TaskDate);
            Assert.AreEqual(remind, test.Remind);
            Assert.AreEqual(remind1Date, test.ReminderDate);
            if (filename != "")
            {
                Assert.AreEqual(Environment.CurrentDirectory + @"\390.txt", test.FileName);
            }
            
        }

        [Test]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", false, @"C:\Users\Valeriy\Desktop\390.txt",
            TestName = "Позитивный тест конструктора: без напоминанием, с прикрепленным файлом")]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", false, "",
            TestName = "Позитивный тест конструктора: без напоминанием, без прикрепленного файла")]
        public void ConstructorWithouRemindDiaryTaskTest(string name, string taskDateString, bool remind, string filename)
        {
            DateTime.TryParse(taskDateString, out var taskDate);
            var test = new DiaryTask(name, taskDate, remind, filename);
            Assert.AreEqual(name, test.Name);
            Assert.AreEqual(taskDate, test.TaskDate);
            Assert.AreEqual(remind, test.Remind);
            if (filename != "")
            {
                Assert.AreEqual(Environment.CurrentDirectory + @"\390.txt", test.FileName);
            }
        }

        [Test]
        [TestCase("аааааааааааааааааааааааааааааааааааааааааааааааааааааааааааа", "2019.12.13 0:00:00", true, @"C:\Users\Valeriy\Desktop\390.txt", "2019.12.12 0:00:00",
            TestName = "Негативный тест имени: больше 50 символов")]
        [TestCase("Что-то сделать", "1800.12.13 0:00:00", false, "", "2019.12.12 0:00:00",
            TestName = "Негативный тест даты задачи: раньше 1901 года")]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", true, "", "2019.12.14 0:12:00",
            TestName = "Негативный тест даты напоминания: позже даты задачи")]
        [TestCase("Что-то сделать", "2019.12.13 0:00:00", true, @"C:\Users\Valeriy\Desktop\1231231231312312312.333", "2019.12.12 0:00:00",
            TestName = "Негативный тест прикрепленного файла файла: файл отстутсвует")]
        public void NegativeNameDiaryTaskTest(string name, string taskDateString, bool remind, string filename, string remindDate)
        {
            DateTime.TryParse(taskDateString, out var taskDate);
            DateTime.TryParse(remindDate, out var remind1Date);
            Assert.Throws<ArgumentException>(() =>{ var test = new DiaryTask(name, taskDate, remind, filename, remindDate); },"Error");
        }
    }
}