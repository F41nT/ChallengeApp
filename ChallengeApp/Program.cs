using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

List<Employee> employees = new List<Employee>();

Employee Employee1 = new Employee("Ewa", "Nowak", "29");
Employee Employee2 = new Employee("Tomek", "Sokolski", "31");
Employee Employee3 = new Employee("Kamil", "Motyl", "27");
Employee Employee4 = new Employee("Dorota", "Kowalska", "36");

//Employee1.AddGrade(-1.7976931348623157E+308);
//Employee1.AddGrade("1");
//Employee1.AddGrade(3.402823466E+38);
//Employee1.AddGrade(9223372036854775807);
//Employee1.AddGrade(92);

Employee2.AddGrade(5);
Employee2.AddGrade(1);
Employee2.AddGrade(7);
Employee2.AddGrade(5);
Employee2.AddGrade(5);

Employee3.AddGrade(9);
Employee3.AddGrade(6);
Employee3.AddGrade(8);
Employee3.AddGrade(9);
Employee3.AddGrade(9);

Employee4.AddGrade(10);
Employee4.AddGrade(1);
Employee4.AddGrade(6);
Employee4.AddGrade(6);
Employee4.AddGrade(6);

var statistics2 = Employee2.GetStatisticsWithForEach();
var statistics3 = Employee3.GetStatisticsWithFor();
var statistics4 = Employee4.GetStatisticsWithDoWhile();
var statistics5 = Employee4.GetStatisticsWithWhile();

//float maxResult = -1;
//Employee? employeeWithMaxResult = null;

//foreach (var employee in employees)
//{
//    if (employee.Result > maxResult)
//    {
//        employeeWithMaxResult = employee;
//        maxResult = employee.Result;
//    }
//}

//Console.WriteLine("Pracownik z najwyższą oceną to: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + " lat");
//Console.WriteLine("Wynik jaki osiągnął/ęła wynosi: " + employeeWithMaxResult.Result + " punktów");

//Console.WriteLine($"Average: {statistics1.Avg}");
//Console.WriteLine($"Maximum: {statistics1.Max}");
//Console.WriteLine($"Minimum: {statistics1.Min}");
Console.WriteLine("GetStatisticsWithForEach");
Console.WriteLine($"Average: {statistics2.Avg}");
Console.WriteLine($"Maximum: {statistics2.Max}");
Console.WriteLine($"Minimum: {statistics2.Min}");
Console.WriteLine("GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics3.Avg}");
Console.WriteLine($"Maximum: {statistics3.Max}");
Console.WriteLine($"Minimum: {statistics3.Min}");
Console.WriteLine("GetStatisticsWithDoWhile");
Console.WriteLine($"Average: {statistics4.Avg}");
Console.WriteLine($"Maximum: {statistics4.Max}");
Console.WriteLine($"Minimum: {statistics4.Min}");
Console.WriteLine("GetStatisticsWithWhile");
Console.WriteLine($"Average: {statistics5.Avg}");
Console.WriteLine($"Maximum: {statistics5.Max}");
Console.WriteLine($"Minimum: {statistics5.Min}");