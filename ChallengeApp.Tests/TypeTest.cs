namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckIfTwoEmplyeesAreDifferentUsers()
        {
            //Arrange
            var employee1 = GetEmployee("Jan", "Kowalski","60");
            var employee2 = GetEmployee("Jan", "Kowalski", "60");

            //Assert
            Assert.AreNotEqual(employee1, employee2);

        }
        [Test]
        public void CheckIfDoubleValuesAreNotEqual()
        {
            //Arrange
            var value1 = 1.231;
            var value2 = 2.145;

            //Assert
            Assert.AreNotEqual(value1, value2);

        }
        [Test]
        public void CheckIfStringValuesAreEqual()
        {
            //Arrange
            var value1 = 1;
            var value2 = 1;

            //Assert
            Assert.AreEqual(value1, value2);

        }
        [Test]
        public void CheckIfStringsNameAreEqual()
        {
            //Arrange
            var name1 = "Ewa";
            var name2 = "Ewa";

            //Assert
            Assert.AreEqual(name1, name2);

        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age) ;
        }
    }
}
