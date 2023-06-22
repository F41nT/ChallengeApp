string name = "Adam"; // "Ewa" or "Adam"
string sex1 = "Kobieta";
string sex2 = "Mężczyżna";
int age = 18;

if (name == "Ewa")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletnia " + sex1);
    }
    else if (age > 30)
    {
        Console.WriteLine(name + ", lat " + age);
    }
    else if (age < 30)
    {
        Console.WriteLine(sex1 + " poniżej 30 lat");
    }
};

if (name == "Adam")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni " + sex2);
    }
    else if (age > 30)
    {
        Console.WriteLine(name + ", lat " + age);
    }
    else if (age < 30)
    {
        Console.WriteLine(sex2 + " poniżej 30 lat");
    }
};
