namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        protected string Name { get; private set; }
        protected string Surname { get; private set; }
        protected string Age { get; private set; }
    }
}
