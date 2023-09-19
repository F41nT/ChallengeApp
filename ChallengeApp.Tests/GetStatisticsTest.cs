namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenNewEmployeeCollectNewGradesInDigits_ShouldReturnCorrectGradeLetter()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(30);
            employee1.AddGrade(30);
            employee1.AddGrade(20);
            employee1.AddGrade(40);

            employee2.AddGrade(100);
            employee2.AddGrade(100);
            employee2.AddGrade(100);
            employee2.AddGrade(100);

            //Act

            var statistics1 = employee1.GetStatisticsWithWhile();
            var statistics2 = employee2.GetStatisticsWithWhile();

            //Assert

            Assert.AreEqual('D', statistics1.AvgLetter);
            Assert.AreEqual('A', statistics2.AvgLetter);
        }
        [Test]
        public void WhenNewEmployeeCollectNewGradesInLetters_ShouldReturnCorrectGradeLetter()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade('a');
            employee1.AddGrade('b');
            employee1.AddGrade('c');
            employee1.AddGrade('B');

            employee2.AddGrade('d');
            employee2.AddGrade('d');
            employee2.AddGrade('d');
            employee2.AddGrade('D');

            //Act

            var statistics1 = employee1.GetStatisticsWithWhile();
            var statistics2 = employee2.GetStatisticsWithWhile();

            //Assert 

            Assert.AreEqual('B', statistics1.AvgLetter);
            Assert.AreEqual('D', statistics2.AvgLetter);
        }
        [Test]
        public void WhenNewEmployeeCollectNewGradesMixed_ShouldReturnCorrectGradeLetter()
        {
            //Arrange
            var employee1 = new Employee("Wojtek", "Kowalski", "42");
            var employee2 = new Employee("Patrycja", "Klon", "22");

            employee1.AddGrade(100);
            employee1.AddGrade('b');
            employee1.AddGrade(60);
            employee1.AddGrade('B');

            employee2.AddGrade(40);
            employee2.AddGrade('d');
            employee2.AddGrade(40);
            employee2.AddGrade('D');

            //Act

            var statistics1 = employee1.GetStatisticsWithWhile();
            var statistics2 = employee2.GetStatisticsWithWhile();

            //Assert 

            Assert.AreEqual('B', statistics1.AvgLetter);
            Assert.AreEqual('D', statistics2.AvgLetter);
        }
    }
}