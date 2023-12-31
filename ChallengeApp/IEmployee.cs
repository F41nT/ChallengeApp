﻿namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Age { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}

