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
            employee1.AddScore(5);
            employee1.AddScore(9);
            employee1.AddScore(-9);
            employee1.AddScore(-5);
            employee2.AddScore(5);
            employee2.AddScore(5);
            employee2.AddScore(5);
            employee2.AddScore(-20);

            //Act
            int result = employee1.Result;
            var result2 = employee2.Result;
            //Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(-5, result2);
        }
    }
}