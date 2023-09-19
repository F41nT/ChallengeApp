﻿using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

List<Employee> employees = new List<Employee>();
var employee = new Employee("Wojtek", "Kaluza", "43");

Console.WriteLine("Program Wu do oceny pracowników");
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika");
var input1 = Console.ReadLine();
if (input1 == "q" || input1 == "Q") 
{
    Environment.Exit(0);
}
try
{
    employee.AddGrade(input1);
}
catch (Exception ex)
{
    Console.WriteLine($"Znaleziono wyjątek: {ex.Message}");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input2 = Console.ReadLine();
    if (input2 == "q" || input2 == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input2);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Znaleziono wyjątek: {ex.Message}");
    }
}

Console.WriteLine();

var statistics = employee.GetStatisticsWithWhile();

Console.WriteLine($"Średnia: {statistics.Avg}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Ocena końcowa: {statistics.AvgLetter}");