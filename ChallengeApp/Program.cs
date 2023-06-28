using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

Employee Employee1 = new Employee("Ewa","Nowak","29");
Employee Employee2 = new Employee("Tomek","Sokolski","31");
Employee Employee3 = new Employee("Kamil","Motyl","27");
Employee Employee4 = new Employee("Dorota","Kowalska","36");

Employee1.AddScore(10);
Employee1.AddScore(10);
Employee1.AddScore(10);
Employee1.AddScore(10);
Employee1.AddScore(10);

Employee2.AddScore(5);
Employee2.AddScore(1);
Employee2.AddScore(7);
Employee2.AddScore(5);
Employee2.AddScore(5);

Employee3.AddScore(9);
Employee3.AddScore(6);
Employee3.AddScore(8);
Employee3.AddScore(9);
Employee3.AddScore(9);

Employee4.AddScore(10);
Employee4.AddScore(1);
Employee4.AddScore(6);
Employee4.AddScore(6);
Employee4.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    Employee1, Employee2, Employee3, Employee4
};

var maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownik z najwyższą oceną to: " + employeeWithMaxResult.Name +" "+ employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + " lat");
Console.WriteLine("Wynik jaki osiągnął/ęła wynosi: " + employeeWithMaxResult.Result + " punktów");