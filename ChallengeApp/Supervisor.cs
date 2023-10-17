
namespace ChallengeApp
{
    public class Supervisor : Person, IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, string age)
            : base(name, surname, age)
        {
        }
        public Supervisor(string name, string surname)
            : this(name, surname, "brak wieku")
        {
        }
        public Supervisor(string name)
            : this(name, "brak nazwiska", "brak wieku")
        {
        }
        public void AddGrade(float grade)
        {
            if (grade.Equals(0) || grade >= 1 && grade <= 105)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę 0 lub wartość od 7 do 105, a w przypadku szkolnej skali ocen wartości od '+1' do '+6' lub od 'a' do 'f'");
            }
        }
        public void AddGrade(string grade)
        {
            if (grade.Length == 2)
            {
                switch (grade)
                {
                    case "6+":
                    case "+6":
                        this.AddGrade(105);
                        break;
                    case "6-":
                    case "-6":
                        this.AddGrade(95);
                        break;
                    case "5+":
                    case "+5":
                        this.AddGrade(85);
                        break;
                    case "5-":
                    case "-5":
                        this.AddGrade(75);
                        break;
                    case "4+":
                    case "+4":
                        this.AddGrade(65);
                        break;
                    case "4-":
                    case "-4":
                        this.AddGrade(55);
                        break;
                    case "3+":
                    case "+3":
                        this.AddGrade(45);
                        break;
                    case "3-":
                    case "-3":
                        this.AddGrade(35);
                        break;
                    case "2+":
                    case "+2":
                        this.AddGrade(25);
                        break;
                    case "2-":
                    case "-2":
                        this.AddGrade(15);
                        break;
                    case "1+":
                    case "+1":
                        this.AddGrade(5);
                        break;
                    default:
                        if (float.TryParse(grade, out float result))
                        {
                            this.AddGrade(result);
                        }
                        else
                        {
                            throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę 0 lub wartość od 7 do 105, a w przypadku szkolnej skali ocen wartości od '+1' do '+6' lub od 'a' do 'f'");
                        }
                        break;
                }
            }
            else if (grade.Length == 1)
            {
                char a = char.Parse(grade);
                this.AddGrade(a);
            }
            else if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę 0 lub wartość od 7 do 105, a w przypadku szkolnej skali ocen wartości od '+1' do '+6' lub od 'a' do 'f'");
            }

        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case '6':
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case '5':
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case '4':
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case '3':
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case '2':
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                case '0':
                case '1':
                case 'F':
                case 'f':
                    this.AddGrade(0);
                    break;
                case '7':
                case '8':
                case '9':
                    char b = grade;
                    int a = (int)Char.GetNumericValue(b);
                    this.AddGrade(a);
                    break;
                default:
                    throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę 0 lub wartość od 7 do 105, a w przypadku szkolnej skali ocen wartości od '+1' do '+6' lub od 'a' do 'f'");
            }

        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;

            statistics.Max = float.MinValue;

            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Avg += this.grades[index];
                index++;
            }

            statistics.Avg /= this.grades.Count;

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
