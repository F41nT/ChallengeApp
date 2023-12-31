
﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;


namespace ChallengeApp
{
    public class Employee : Person,IEmployee
    {

        private List<float> grades = new List<float>();
        public Employee(string name, string surname, string age)
            :base(name, surname, age)
        {
            
        }
        public Employee(string name, string surname)
            :this(name, surname, "brak wieku")
        {

        }
        public Employee(string name)
            :this(name, "brak nazwiska", "brak wieku")
        {

        }
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
                throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
            }
        }

        public void AddGrade(string grade)
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
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
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
