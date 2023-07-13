using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

Employee Employee1 = new Employee("Ewa", "Nowak", "29");
Employee Employee2 = new Employee("Tomek", "Sokolski", "31");
Employee Employee3 = new Employee("Kamil", "Motyl", "27");
Employee Employee4 = new Employee("Dorota", "Kowalska", "36");

Employee1.AddGrade(1);
Employee1.AddGrade(5);
Employee1.AddGrade(10);
Employee1.AddGrade(8);
Employee1.AddGrade(7);

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

var statistics0 = Employee1.GetStatistics();
var statistics1 = Employee2.GetStatistics();
var statistics2 = Employee3.GetStatistics();
var statistics3 = Employee4.GetStatistics();

//List<Employee> employees = new List<Employee>()
//{
//    Employee1, Employee2, Employee3, Employee4
//};

//float maxResult = -1;
//Employee employeeWithMaxResult = null;

//foreach (var employee in employees)
//{
//    if(employee.Result > maxResult)
//    {
//        employeeWithMaxResult = employee;
//        maxResult = employee.Result;
//   }
//}

//Console.WriteLine("Pracownik z najwyższą oceną to: " + employeeWithMaxResult.Name +" "+ employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + " lat");
//Console.WriteLine("Wynik jaki osiągnął/ęła wynosi: " + employeeWithMaxResult.Result + " punktów");

Console.WriteLine($"Average: {statistics0.Avg}");
Console.WriteLine($"Maximum: {statistics0.Max}");
Console.WriteLine($"Minimum: {statistics0.Min}");

Console.WriteLine($"Average: {statistics1.Avg}");
Console.WriteLine($"Maximum: {statistics1.Max}");
Console.WriteLine($"Minimum: {statistics1.Min}");

Console.WriteLine($"Average: {statistics2.Avg}");
Console.WriteLine($"Maximum: {statistics2.Max}");
Console.WriteLine($"Minimum: {statistics2.Min}");

Console.WriteLine($"Average: {statistics3.Avg}");
Console.WriteLine($"Maximum: {statistics3.Max}");
Console.WriteLine($"Minimum: {statistics3.Min}");
