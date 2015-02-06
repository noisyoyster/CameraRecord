using System;
using NUnit.Framework;
using CameraRecord;
namespace CameraRecordTest
{
    [TestFixture]
    public class SnapTest
    {
        [Test]
        public void TestCaptureDate()
        {
            Snap click = new Snap();

            DateTime nownow = new DateTime();
            click.CaptureDate = nownow;

            Assert.AreEqual(nownow, click.CaptureDate);


        }
    }
}
