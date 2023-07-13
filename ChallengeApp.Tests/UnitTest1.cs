namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenNewEmployeeCollectNewGrades_ShouldReturnCorrectMaxUsingGetStatistics()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(3);
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(4);

            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);

            //Act

            var statistics1 = employee1.GetStatistics();
            var statistics2 = employee2.GetStatistics();

            //Assert
            Assert.AreEqual(4, statistics1.Max);
            Assert.AreEqual(1, statistics2.Max);

        }
        [Test]
        public void WhenNewEmployeeCollectNewGrades_ShouldReturnCorrectMinUsingGetStatistics()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(3);
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(4);

            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);

            //Act

            var statistics1 = employee1.GetStatistics();
            var statistics2 = employee2.GetStatistics();

            //Assert

            Assert.AreEqual(1, statistics1.Min);
            Assert.AreEqual(1, statistics2.Min);
        }
        [Test]
        public void WhenNewEmployeeCollectNewGrades_ShouldReturnCorrectAvgUsingGetStatistics()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(3);
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(4);

            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(1);

            //Act

            var statistics1 = employee1.GetStatistics();
            var statistics2 = employee2.GetStatistics();

            //Assert

            Assert.AreEqual(2.5, statistics1.Avg);
            Assert.AreEqual(1, statistics2.Avg);
        }
        [Test]
        public void WhenNewEmployeeCollectNewGrades_ShouldReturnCorrectAvgUsingGetStatistics2()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(4);
            employee1.AddGrade(9);
            employee1.AddGrade(9);

            employee2.AddGrade(5);
            employee2.AddGrade(9);
            employee2.AddGrade(3);

            //Act

            var statistics1 = employee1.GetStatistics();
            var statistics2 = employee2.GetStatistics();

            //Assert

            Assert.AreEqual(Math.Round(7.33, 2), Math.Round(statistics1.Avg, 2));
            Assert.AreEqual(Math.Round(5.67, 2), Math.Round(statistics2.Avg, 2));
        }
    }
}