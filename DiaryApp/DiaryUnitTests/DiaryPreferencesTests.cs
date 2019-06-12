using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DiaryAppLibs;
using NUnit;
using NUnit.Framework;

namespace DiaryUnitTests
{
    public class DiaryPreferencesTests
    {
        private Color _color;
        private Color _fontColor;
        private string _path;

        [SetUp]
        public void Setup()
        {
            _path = @"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests" + @"\-click-nice_1.mp3";
            _fontColor = Color.Green;
            _color = Color.LightSalmon;
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест конструктора")]
        public void ConstructorDiaryPrefTest()
        {
            DiaryPreferences diaryPreferences = new DiaryPreferences(_path, _fontColor, _color);
            Assert.AreEqual(_color, diaryPreferences.Color);
            Assert.AreEqual(_fontColor,diaryPreferences.FontColor);
            Assert.AreEqual(_path, diaryPreferences.AudioPath);
        }

        [Test]
        [TestCase(@"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests" + @"\-click-nice_1.ogg", "Green", "LightSalmon",
            TestName = "Негативный тест конструктора : неподдерживаемое расширение файла")]
        [TestCase(@"C:\Users\Valeriy\Desktop\diary\diary\DiaryApp\DiaryAppUnitTests" + @"\123123123123123.mp3", "Green", "LightSalmon",
            TestName = "Негативный тест конструктора : файл не найден")]
        public void NegativeConstructorDiaryPrefTest(string path, string fontColorString, string colorString)
        {
            var color = Color.FromName(colorString);
            var fontColor = Color.FromName(fontColorString);
            
            Assert.Throws<ArgumentException>(() => { DiaryPreferences diaryPreferences = new DiaryPreferences(path, fontColor, color); }, "Error");
        }
    }
}