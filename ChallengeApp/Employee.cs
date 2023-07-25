using System.Diagnostics;

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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
               this.AddGrade(result);
            }
            else
            {
               Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
            if (grade <= float.MaxValue && grade >= float.MinValue)
            {
                this.AddGrade((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
      
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(byte grade)
        {
            this.AddGrade((float)grade);
        }
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();

            statistics.Avg = 0;

            statistics.Max = float.MinValue;

            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Avg += this.grades[index];
                index++;
            } while (index < this.grades.Count);

         //   foreach (var grade in this.grades) 
         //   { 
         //       statistics.Max = Math.Max(statistics.Max, grade);
         //      statistics.Min = Math.Min(statistics.Min, grade);
         //       statistics.Avg += grade;
         //   }
            statistics.Avg /= this.grades.Count;
            return statistics;
        }
    }
}
