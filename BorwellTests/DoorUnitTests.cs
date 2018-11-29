using BorwellChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BorwellTests
{

    [TestClass]

    public class DoorUnitTests

    {

        [TestMethod]
        public void DoorArea1()
        {
            double expectedDoorSize = 15.00, width = 15.00, height = 1.00;

            Doors doors = new Doors(width, height, 1);

            Assert.AreEqual(expectedDoorSize, doors.GetArea());
        }

        [TestMethod]
        public void DoorArea2()
        {
            double expectedDoorSize = 125.00, width = 25.00, height = 5;

            Doors doors = new Doors(width, height, 1);

            Assert.AreEqual(expectedDoorSize, doors.GetArea());
        }
    }
}