using System;
using ExtensionMethods;
namespace AgeMethode_Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void ReturnZero_WhenInputAndBirthIsTheSame()
        {
            DateTime birth = new DateTime(2000, 1, 1);

            int age = birth.Age(new DateTime(2000, 1, 1));

            Assert.AreEqual(0, age);
        }
        [TestMethod]
        public void ReturnZero_WhenInputIsLessThenBirth()
        {
            DateTime birth = new DateTime(2000, 1, 1);

            int age = birth.Age(new DateTime(1990, 1, 1));

            Assert.AreEqual(0, age);
        }
        [TestMethod]
        public void ReturTen_WhenInputIsTenYearsLaterThenBirth()
        {
            DateTime birth = new DateTime(2000, 1, 1);

            int age = birth.Age(new DateTime(2020, 1, 1));

            Assert.AreEqual(20, age);
        }
    }
}

