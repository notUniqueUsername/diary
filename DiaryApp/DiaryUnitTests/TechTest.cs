using System;
using DiaryAppLibs;
using NUnit.Framework;

namespace DiaryUnitTests
{
    public class TechTest
    {
        DiaryTask _diaryTask;
        private DiaryTaskListContainer _diaryTaskList = new DiaryTaskListContainer();

        [SetUp]
        public void Setup()
        {
            for (int i = 0; i < 100000; i++)
            {
                string name = $"{i}";
                _diaryTask = new DiaryTask(name, new DateTime(2019, 1, 1), false);
                _diaryTaskList.TaskList.Add(_diaryTask);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест скорости сохранения")]
        public void SaveTechTest()
        {
            {
                Assert.DoesNotThrow(() =>
                {
                    SaveLoad.SaveToFile(_diaryTaskList,
                            @"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests\tech.diary")
                        ;
                });
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест скорости загрузки")]
        public void LoadTechTest()
        {
            {
                Assert.DoesNotThrow(() =>
                {
                    SaveLoad.LoadFromFile(@"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests\tech.diary")
                        ;
                });
            }
        }
    }
}