namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();

            statistics.Avg = 0;

            statistics.Max = float.MinValue;

            statistics.Min = float.MaxValue;
           
            
            foreach (var grade in this.grades) 
            { 
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }
            statistics.Avg /= this.grades.Count;
            return statistics;
        }
    }
}
