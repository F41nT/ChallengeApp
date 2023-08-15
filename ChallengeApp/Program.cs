using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

List<Employee> employees = new List<Employee>();

Employee Employee1 = new Employee("Ewa", "Nowak", "29");
Employee Employee2 = new Employee("Tomek", "Sokolski", "31");
Employee Employee3 = new Employee("Kamil", "Motyl", "27");
Employee Employee4 = new Employee("Dorota", "Kowalska", "36");

var statistics5 = Employee4.GetStatisticsWithWhile();


var employee = new Employee("Wojtek", "Kaluza", "43");
Console.WriteLine("Program Wu do oceny pracowników");
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika");
var input1 = Console.ReadLine();
if (input1 == "A" || input1 == "B" || input1 == "C" || input1 == "D" || input1 == "E" || input1 == "a" || input1 == "b" || input1 == "c" || input1 == "d" || input1 == "e")
{
    var LetterInput = Convert.ToChar(input1);
    employee.AddGrade(LetterInput);
}
else if (input1 == "q" || input1 == "Q")
{
    Environment.Exit(0);
}
else
{
    employee.AddGrade(input1);
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input2 = Console.ReadLine();
    if (input2 == "q" || input2 == "Q")
    {
        break;
    }
    else if (input2 == "A" || input2 == "B" || input2 == "C" || input2 == "D" || input2 == "E" || input2 == "a" || input2 == "b" || input2 == "c" || input2 == "d" || input2 == "e")
    {
        var LetterInput = Convert.ToChar(input2);
        employee.AddGrade(LetterInput);
    }
    else
    {
        employee.AddGrade(input2);
    }
}

Console.WriteLine();

var statistics = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics.Avg}");
Console.WriteLine($"Maximum: {statistics.Max}");
Console.WriteLine($"Minimum: {statistics.Min}");
Console.WriteLine($"Ocena: {statistics.AvgLetter}");