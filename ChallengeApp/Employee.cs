
﻿using System;
using System.Diagnostics;
using System.Reflection;


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
                Console.WriteLine("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
            }
        }
      
        //public void AddGrade(int grade)
        //{
        //    this.AddGrade((float)grade);
        //}

        //public void AddGrade(long grade)
        //{
        //    this.AddGrade((float)grade);
        //}

        //public void AddGrade(byte grade)
        //{
        //    this.AddGrade((float)grade);
        //}
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
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
            }
            switch (grade)
            {
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
            }
            switch (grade)
            {
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
            }
            switch (grade)
            {
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
            }
            switch (grade)
            {
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
            }
        }
        //public void AddGrade(double grade)
        //{
        //    if (grade <= float.MaxValue && grade >= float.MinValue)
        //    {
        //        this.AddGrade((float)grade);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Podana wartość jest nieprawidłowa, wpisać liczbę od 0 do 100, a w przypadku liter stosować oceny od a do e");
        //    }
        //}
        public Statistics GetStatisticsWithWhile()
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
        //public Statistics GetStatisticsWithDoWhile()
        //{
        //    var statistics = new Statistics();

        //    statistics.Avg = 0;

        //    statistics.Max = float.MinValue;

        //    statistics.Min = float.MaxValue;

        //    var index = 0;

        //    do
        //    {
        //        statistics.Max = Math.Max(statistics.Max, this.grades[index]);
        //        statistics.Min = Math.Min(statistics.Min, this.grades[index]);
        //        statistics.Avg += this.grades[index];
        //        index++;
        //    } while (index < this.grades.Count);

        //    statistics.Avg /= this.grades.Count;
        //    return statistics;
        //}

        //public Statistics GetStatisticsWithForEach()
        //{
        //    var statistics = new Statistics();

        //    statistics.Avg = 0;

        //    statistics.Max = float.MinValue;

        //    statistics.Min = float.MaxValue;

        //    foreach (var grade in this.grades)
        //    {
        //        statistics.Max = Math.Max(statistics.Max, grade);
        //        statistics.Min = Math.Min(statistics.Min, grade);
        //        statistics.Avg += grade;
        //    }

        //    statistics.Avg /= this.grades.Count;
        //    return statistics;
        //}

        //public Statistics GetStatisticsWithFor()
        //{
        //    var statistics = new Statistics();

        //    statistics.Avg = 0;

        //    statistics.Max = float.MinValue;

        //    statistics.Min = float.MaxValue;

        //    for (var i=0;i<this.grades.Count;i++)
        //    {
        //        statistics.Max = Math.Max(statistics.Max, this.grades[i]);
        //        statistics.Min = Math.Min(statistics.Min, this.grades[i]);
        //        statistics.Avg += this.grades[i];
        //    }

        //    statistics.Avg /= this.grades.Count;
        //    return statistics;
        //}
    }
}
//restart