namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                }
                else
                {
                    throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
                }
            }
        }
        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char a = char.Parse(grade);
                this.AddGrade(a);
            }
            else
            {
                throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
            }

        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
            }

        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }

            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            statistics.Avg = 0;

            statistics.Max = float.MinValue;

            statistics.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
                index++;
            }

            statistics.Avg /= grades.Count;

            switch (statistics.Avg)
            {
                case var avg when avg >= 85:
                    statistics.AvgLetter = 'A';
                    break;
                case var avg when avg >= 65:
                    statistics.AvgLetter = 'B';
                    break;
                case var avg when avg >= 45:
                    statistics.AvgLetter = 'C';
                    break;
                case var avg when avg >= 25:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    statistics.AvgLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
            