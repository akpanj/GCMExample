using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCM.MenuApp.App;

namespace GCM.MenuApp.Test
{
    [TestClass]
    public class DishTest
    {
        [TestMethod]
        public void TestMorning123()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("morning,1,2,3");
            string actual = factory.GetMenu();
            string expected = "eggs, toast, coffee";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Morning213()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("morning, 2, 1, 3");
            string actual = factory.GetMenu();
            string expected = "eggs, toast, coffee";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Morning1234()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("morning, 1, 2, 3, 4");
            string actual = factory.GetMenu();
            string expected = "eggs, toast, coffee, error";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Morning12333()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("morning, 1, 2, 3, 3, 3");
            string actual = factory.GetMenu();
            string expected = "eggs, toast, coffee(x3)";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Night1234()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("night, 1, 2, 3, 4");
            string actual = factory.GetMenu();
            string expected = "steak, potato, wine, cake";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Night1224()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("night, 1, 2, 2, 4");
            string actual = factory.GetMenu();
            string expected = "steak, potato(x2), cake";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Night1235()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("night, 1, 2, 3, 5");
            string actual = factory.GetMenu();
            string expected = "steak, potato, wine, error";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Night11235()
        {
            ProcessMenuFactory factory = new ProcessMenuFactory("night, 1, 1, 2, 3, 5");
            string actual = factory.GetMenu();
            string expected = "steak, error";
            Assert.AreEqual(expected, actual);
        }

    }
}
