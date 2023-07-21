using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenNewEmployeeCollectNewGrades_ShouldReturnCorrectSum()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");
            employee1.AddGrade(5);
            employee1.AddGrade(9);
            employee1.AddGrade(-9);
            employee1.AddGrade(-5);
            employee2.AddGrade(5);
            employee2.AddGrade(5);
            employee2.AddGrade(5);
            employee2.AddGrade(-20);

            //Act
            float result = employee1.Result;
            var result2 = employee2.Result;
            //Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(-5, result2);
        }
    }
}