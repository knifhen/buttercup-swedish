using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Buttercup.Control.Model;
using NUnit.Framework;

namespace ButtercupTests
{
    [TestFixture]
    public class ValueConversionHelperTest
    {
        [Test]
        public void ShouldConvertMilliseconds()
        {
            const string inputString = "0:00:02.447";
            //            (2010-11-27 19:36:29) - OpenAsync Audio File http://www.blissbulletinen.se/opf/2009_1/Karalasare/speechgen0001.mp3. 0:00:02.447 - 0:00:05.702


            TimeSpan convertedTimeSpan = ValueConversionHelper.GetConvertedTimeSpan(inputString);
            Assert.AreEqual(0, convertedTimeSpan.Hours);
            Assert.AreEqual(0, convertedTimeSpan.Minutes);
            Assert.AreEqual(2, convertedTimeSpan.Seconds);
            Assert.AreEqual(447, convertedTimeSpan.Milliseconds, "should have converted millis");
        }
    }
}
