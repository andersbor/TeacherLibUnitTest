using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TeacherLib.Tests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void TestSalary()
        {
            Teacher teacher = new Teacher("Anders", 1);
            //teacher.Salary = 1;
            Assert.AreEqual(1, teacher.Salary);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = 1000000);
        }

        [TestMethod]
        public void TestName()
        {
            Teacher teacher = new Teacher("Ib", 100);
            //teacher.Name = "Ib";
            Assert.AreEqual("Ib", teacher.Name);

            Assert.ThrowsException<ArgumentException>(() => teacher.Name = "Y");
        }

        [TestMethod]
        public void ToStringTest()
        {
            Teacher teacher = new Teacher("Anders", 100);
            Assert.AreEqual("Anders 100", teacher.ToString());
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.ThrowsException<ArgumentException>(() => new Teacher("A", 100));
        }

        [TestMethod]
        public void TestPi()
        {
            Assert.AreEqual(3.1415, Teacher.Pi, 0.0001);
        }
    }
}