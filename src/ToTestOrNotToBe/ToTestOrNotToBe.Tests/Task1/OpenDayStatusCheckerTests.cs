using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToTestOrNotToBe.Tasks.Task1;

namespace ToTestOrNotToBe.Tests.Task1
{
    [TestClass]
    public class OpenDayStatusCheckerTests
    {
        [TestMethod]
        public void IsOpen_ShouldReturnTrue()
        {
            var openDayStatusChecker = new OpenDayStatusChecker();

            bool isOpen = openDayStatusChecker.IsOpen();

            Assert.IsTrue(isOpen);
        }
    }
}